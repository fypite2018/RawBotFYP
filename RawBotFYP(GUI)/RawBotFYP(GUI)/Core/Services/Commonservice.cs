using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RawBotFYP.Core.Services
{
    public class Commonservice
    {
        #region DefinitionService
        public class DefinitionService
        {
            public static async Task<Data> GetDefinitionForTermAsync(string query)
            {
                using (var http = new HttpClient())
                {
                    var result = await http.GetStringAsync($"http://api.pearson.com/v2/dictionaries/entries?headword={WebUtility.UrlEncode(query.Trim())}");
                    return JsonConvert.DeserializeObject<Data>(result);
                }
            }
            public class Data
            {
                public List<Result> Results { get; set; }
            }

            public class Result
            {
                public string Part_of_speech { get; set; }
                public List<Sens> Senses { get; set; }
                public string Url { get; set; }
            }

            public class Sens
            {
                public object Definition { get; set; }
                public List<Example> Examples { get; set; }
                public GramaticalInfo Gramatical_info { get; set; }
            }

            public class Example
            {
                public List<Audio> audio { get; set; }
                public string text { get; set; }
            }

            public class GramaticalInfo
            {
                public string type { get; set; }
            }

            public class Audio
            {
                public string url { get; set; }
            }
        }
        #endregion
    }
}
