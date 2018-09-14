using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.WebSocket;
using Discord.Commands;

using Google.Apis.YouTube.v3;

using RawBotFYP_GUI_.Core.Data;
using Newtonsoft.Json.Linq;
using RawBotFYP.Core.Services;
using Google.Apis.Services;

namespace RawBotFYP_GUI_.Core.Commands 
{
    #region Methods
    public class EntertainMethods
    {
        public EmbedBuilder CreateEmbled(string Author, string Description)       // Methods to Create a Embled
        {
            EmbedBuilder Embedb = new EmbedBuilder();
            Embedb.WithAuthor(Author);
            Embedb.WithColor(40, 200, 150);
            Embedb.WithDescription(Description);
            Embedb.Build();
            return Embedb;
        }
    }
    #endregion

    #region Jokes
    public class Jokes : ModuleBase<SocketCommandContext>
    {
        StoreJokes CallJoke = new StoreJokes();

        [Command("jokes")]
        public async Task sayJoke() // Execute jokes
        {
            Random randjoke = new Random();
            int randomgen = randjoke.Next(1, CallJoke.JokeRNG.Count);
            string CallrandJoke = CallJoke.JokeRNG[randomgen];
            await ReplyAsync($"**Jokes Number :** {randomgen} \n{CallrandJoke}", true);
        }
    }
    #endregion

    #region Ping
    public class Ping : ModuleBase<SocketCommandContext>
    {
        [Command("Ping")] // Ping , Pong.
        public async Task PingPong()
        {
            await Context.Channel.SendMessageAsync($"Pong :ping_pong: {Context.Client.Latency}");
        }
    }
    #endregion

    #region RollDice
    public class RollDice : ModuleBase<SocketCommandContext>
    {
        ModerationMethods getMethods = new ModerationMethods();

        [Command("Roll")] // Roll Dice with number
        public async Task sayRollNum([Remainder] int rNum)
        {
            Random RNG = new Random();
            int random = RNG.Next(1, (rNum + 1));
            await ReplyAsync($":game_die: Number Rolled: {random}");
        }
        [Command("roll")] // If Dice command has string parameter
        public async Task ifRollstring([Remainder] string rNum)
        {
            await Context.Channel.SendMessageAsync("", false, getMethods.CreateEmbled("Invalid Command", $"{rNum} is not a Integer.\nPlease have an Integer after the !roll command. Example: !roll 30."));
        }
        [Command("roll")] // if Dice command has no paramater
        public async Task ifnorollnum()
        {
            await Context.Channel.SendMessageAsync("", false, getMethods.CreateEmbled("Invalid Command", "Please have an Integer after the !roll command. Example: !roll 30."));
        }
    }
    #endregion

    #region Pickuser/LuckyDraw
    public class PickUser : ModuleBase<SocketCommandContext>
    {
        [RequireBotPermission(GuildPermission.Administrator)]
        [RequireUserPermission(GuildPermission.Administrator)]
        [Command("PickUser")]
        public async Task userpick()
        {
            Random RNGUser = new Random();
            List<string> UserArrayFiltered = new List<string>();

            foreach (SocketGuildUser User in Context.Guild.Users)
            {
                if (!User.IsBot)
                {
                    if (User.Status.Equals(UserStatus.Online) && !User.Equals(Context.Message.Author))
                    {
                        UserArrayFiltered.Add(User.Username);
                    }
                }
            }

            int numofusers = RNGUser.Next(0, UserArrayFiltered.Count);

            await Context.Channel.SendMessageAsync("Congrats to " + UserArrayFiltered[numofusers] + " for winning the Giveaway!!");
        }
        [Command("PickUser")]
        public async Task UserRequire()
        {
            await ReplyAsync("You do not have the required permissions to run the bot!");
        }
    }
    #endregion

    #region Define
    public class defining : ModuleBase<SocketCommandContext>
    {
        [Command("define")]
        public async Task Dictionary([Remainder] string word = null)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                //if word is empty/missing
                var embed = new EmbedBuilder();
                embed.Title = "Defining " + word;
                embed.WithColor(52, 152, 219);
                embed.Description = ":warning: A word or phrase is required!";
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                var data = await Commonservice.DefinitionService.GetDefinitionForTermAsync(word);
                if (data.Results.Count == 0)
                {
                    //if word can't be found
                    var embed = new EmbedBuilder();
                    embed.Title = "can't find the explantion for " + word;
                    embed.WithColor(52, 152, 219);
                    embed.Description = "No results found!";
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
                else
                    for (var index = 0; index < data.Results.Count; index++)
                        foreach (var value in data.Results[index].Senses)
                            if (value.Definition != null)
                            {
                                var definition = value.Definition.ToString();
                                if (!(value.Definition is string))
                                    definition = ((JArray)JToken.Parse(value.Definition.ToString())).First.ToString();
                                var output = new EmbedBuilder()
                                    .WithTitle($"Dictionary definition for **{word}**")
                                    .WithDescription(definition.Length < 500 ? definition : definition.Take(500) + "...")
                                    .WithColor(52, 152, 219);
                                if (value.Examples != null)
                                    output.AddField("Example", value.Examples.First().text);
                                await Context.Channel.SendMessageAsync("", false, output.Build());
                                index = data.Results.Count;
                                break;
                            }
            }
        }
    }
    #endregion

    #region youtubeSearch
    public class youtubeSearch : ModuleBase<SocketCommandContext>
    {
        [Command("Youtube")]
        public async Task Youtube([Remainder] string Ysearching)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyCiDVoN9suAf6QR97UC6Ca_88RBwVi_yAI",
                ApplicationName = GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = Ysearching;
            searchListRequest.MaxResults = 1;

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = await searchListRequest.ExecuteAsync();

            List<string> videos = new List<string>();
            List<string> channels = new List<string>();

            // Add each result to the appropriate list, and then display the lists of
            // matching videos and channels.
            foreach (var searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
                        await Context.Channel.SendMessageAsync("https://youtube.com/watch?v=" + searchResult.Id.VideoId);
                        break;

                    case "youtube#channel":
                        channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
                        await Context.Channel.SendMessageAsync("https://www.youtube.com/channel/" + searchResult.Id.ChannelId);
                        break;
                }
            }
            Console.WriteLine(String.Format("Videos:\n{0}\n", string.Join("\n", videos)));
            Console.WriteLine(String.Format("Channels:\n{0}\n", string.Join("\n", channels)));
        }
    }
    #endregion
}
