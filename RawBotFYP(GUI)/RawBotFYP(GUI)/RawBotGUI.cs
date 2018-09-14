using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Discord.Rest;

using RawBotFYP_GUI_.Core.Data;

namespace RawBotFYP_GUI_
{
    public partial class RawBotGUI : Form
    {
        #region InitializationOfObjects
        public static DiscordSocketClient Client;
        public static CommandService Commands;
        public static ulong channelID = 420882497937866754; //Raw Bot Channel ID
        public static bool isConnected;
        public static bool eyeClicked = true;
        ToolTip Tips = new ToolTip();
        #endregion

        #region InitializeGUIStartUp
        public RawBotGUI()
        {
            InitializeComponent();
            btn_ShowGuild.Enabled = false;
        }
        #endregion

        #region Connect/Disconnect Button OnClick
        private async void btn_Connect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Token.Text))
            {
                MessageBox.Show("Please Insert A Bot Token", "ERROR");
                return;
            }
            else if (isConnected == false)
            {
                Client = new DiscordSocketClient(new DiscordSocketConfig
                {
                    LogLevel = LogSeverity.Debug,
                });
                Commands = new CommandService(new CommandServiceConfig
                {
                    CaseSensitiveCommands = false,
                    DefaultRunMode = RunMode.Async,
                    LogLevel = LogSeverity.Debug
                });

                await Commands.AddModulesAsync(Assembly.GetEntryAssembly());

                Client.Log += Client_Log;
                Client.Ready += Client_Ready;
                Client.Log += Client_Log;
                Client.UserJoined += Client_WhenUserJoined;
                Client.UserLeft += Client_UserLeft;
                Client.JoinedGuild += Client_JoinedGuild;
                Client.LeftGuild += Client_LeftGuild;
                Client.MessageReceived += Client_MessageReceived;

                try
                {
                    await Client.LoginAsync(TokenType.Bot, txt_Token.Text);
                    await Client.StartAsync();
                    isConnected = true;
                    btn_Connect.Text = "Disconnect";
                }
                catch
                {
                    MessageBox.Show("                             Connection Failed!\n      Please Check Your Token and Internet Connection!", "ERROR");
                }

                await Task.Delay(3000);

            }
            else if (isConnected == true)
            {
                try
                {
                    await Client.LogoutAsync();
                    await Client.StopAsync();
                    isConnected = false;
                    btn_Connect.Text = "Connect";
                    lbl_Connected.Text = "Disconnected";
                    btn_ShowGuild.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Unable To Disconnect", "ERROR");
                }
            }

        }
        #endregion

        #region RichTextBox rtb_Output OnTextChanged
        private void rtb_Output_TextChanged(object sender, EventArgs e)
        {
            rtb_Output.SelectionStart = rtb_Output.TextLength;
            rtb_Output.ScrollToCaret();
        }
        #endregion

        #region Client_Log
        private Task Client_Log(LogMessage arg)
        {
            Invoke((Action)delegate
            {
                rtb_Output.AppendText($"{DateTime.Now} at {arg.Source}] {arg.Message}\n");
                if (isConnected == true)
                {
                    lbl_Connected.Text = $"Connected To {Client.Guilds.Count} Server(s)";
                }
            });
            return null;
        }
        #endregion

        #region Client_JoinedGuild
        private async Task Client_JoinedGuild(SocketGuild arg)
        {
        }
        #endregion

        #region Client_LeftGuild
        private async Task Client_LeftGuild(SocketGuild arg)
        {
        }
        #endregion

        #region Client_WhenUserJoined
        public async Task Client_WhenUserJoined(SocketGuildUser user) // When User Joined the Channel.
        {
            await user.SendMessageAsync($"You have successfully joined **{user.Guild.Name}** Server! :)");
        }
        #endregion

        #region Client_UserLeft
        private async Task Client_UserLeft(SocketGuildUser user)
        {

        }
        #endregion

        #region Client_Ready
        private Task Client_Ready() // Bot's status
        {
            Invoke((Action)delegate
            {
                Client.SetGameAsync($"with ITE", "http://RawBot.com", StreamType.NotStreaming);
                btn_ShowGuild.Enabled = true;
            });
            return null;
        }
        #endregion

        #region Client_MessageReceived
        private async Task Client_MessageReceived(SocketMessage MessageParameter) // Check Messages input from User
        {
            var Message = MessageParameter as SocketUserMessage;
            var Context = new SocketCommandContext(Client, Message);
            StoreVulgarities vulgar = new StoreVulgarities();


            foreach (string badword in vulgar.StoreVulgar) // Filter badwords
            {
                if (Message.Content.ToLower().Contains(badword.ToLower()))
                {
                    await Message.DeleteAsync();
                }
            }
            if (Context.Message == null || Context.Message.Content == "")
            {
                return;
            }
            if (Context.User.IsBot)
            {
                return;
            }

            int ArgPos = 0;
            if (!Message.HasStringPrefix("!", ref ArgPos) && !Message.HasMentionPrefix(Client.CurrentUser, ref ArgPos))
            {
                return;
            }

            var Result = await Commands.ExecuteAsync(Context, ArgPos);
            if (!Result.IsSuccess)
            {
                Console.WriteLine($"{DateTime.Now} at Commands] Something went wrong with executing a command. Text:{Context.Message.Content} | Error: {Result.ErrorReason}");
                #region CheckPermission
                string NoPerm = Result.ErrorReason.ToString();
                if (NoPerm == "User requires guild permission KickMembers" || NoPerm == "User requires guild permission BanMembers" || NoPerm == "User requires guild permission UnbanMembers")
                {
                    await Context.Channel.SendMessageAsync(":x: You do not have the required permissions! :sob:");
                }
                if (NoPerm == "Bot requires guild permission KickMembers" || NoPerm == "Bot requires guild permission BanMembers" || NoPerm == "Bot requires guild permission UnbanMembers")
                {
                    await Context.Channel.SendMessageAsync(":x: Bot do not have the required permissions! :sob:");
                }
                if (NoPerm == "User requires guild permission Administrator" || NoPerm == "Bot requires guild permission Adminstrator")
                {
                    await Context.Channel.SendMessageAsync(":x: Do not have the Adminstrator permissions! :sob:");
                }

                #endregion
            }

        }




        #endregion

        #region ExitAndMinimizeButton
        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region txt.Token Enter/Leave
        private void txt_Token_Enter(object sender, EventArgs e)
        {
            if (txt_Token.Text == "Please Insert Your Bot Token Number Here!")
            {
                txt_Token.Clear();
            }
        }

        private void txt_Token_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Token.Text))
            {
                txt_Token.UseSystemPasswordChar = false;
                txt_Token.ForeColor = System.Drawing.Color.Gray;
                txt_Token.Text = "Please Insert Your Bot Token Number Here!";
            }
        }
        #endregion

        #region pb_Eye Events
        private void pb_Eye_Click(object sender, EventArgs e)
        {
            if (eyeClicked == true && txt_Token.Text != "Please Insert Your Bot Token Number Here!")
            {
                txt_Token.UseSystemPasswordChar = true;
                eyeClicked = false;
            }
            else
            {
                txt_Token.UseSystemPasswordChar = false;
                eyeClicked = true;
            }

        }

        private void pb_Eye_MouseHover(object sender, EventArgs e)
        {
            if (eyeClicked ==true)
            {
                Tips.SetToolTip(this.pb_Eye, "Hide password");
            }
            else
            {
                Tips.SetToolTip(this.pb_Eye, "Show password");
            }
        }
        #endregion
        
        #region btn_ShowGuild onClick
        private void btn_ShowGuild_Click(object sender, EventArgs e)
        {
            FormGuild GuildShow = new FormGuild();
            GuildShow.Visible = true;
        }
        #endregion
    }
}
