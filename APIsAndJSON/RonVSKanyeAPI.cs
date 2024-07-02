using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        private HttpClient _client;

        public RonVSKanyeAPI(HttpClient client)
        {
            _client = client;
        }
        
        public void CallRon()
        {
            string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = _client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse);

            Console.WriteLine($"Ron: {ronQuote[0]}");
        }

        public void CallKanye()
        {
            string kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote");

            Console.WriteLine($"Kanye: {kanyeQuote}");
        }
    }
}
