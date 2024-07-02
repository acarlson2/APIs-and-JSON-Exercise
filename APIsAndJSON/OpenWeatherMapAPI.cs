using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        private HttpClient _client;

        public OpenWeatherMapAPI(HttpClient client)
        {
            _client = client;
        }

        public void GetCurrentTemp(string cityName, string key)
        {
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={key}";

            var tempResponse = _client.GetStringAsync(weatherURL).Result;

            var currentTemp = JObject.Parse(tempResponse).GetValue("main");

            Console.WriteLine(currentTemp);
        }
    }
}
