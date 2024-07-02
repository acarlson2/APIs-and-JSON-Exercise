namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();

            /*RonVSKanyeAPI rVK = new RonVSKanyeAPI(client);

            for(int i = 0; i < 5; i++)
            {
                rVK.CallRon();
                Console.WriteLine("");
                rVK.CallKanye();
                Console.WriteLine("");
            }*/

            OpenWeatherMapAPI weather = new OpenWeatherMapAPI(client);

            weather.GetCurrentTemp("London", "7fe6f8b27cf296fc06874570b629d35f");
        }
    }
}
