using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var kanyeAPI = "https://api.kanye.rest";
            var ronAPI = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
          
            for(int i = 0; i < 5; i++)
            {
                var kResponse = client.GetStringAsync(kanyeAPI).Result;
                var rResponse = client.GetStringAsync(ronAPI).Result;
                Console.WriteLine($"Kanye West: {JObject.Parse(kResponse).GetValue("quote")}");
                Console.WriteLine($"Ron Swanson: {JArray.Parse(rResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim()}");
                Console.WriteLine();
            }
            
        }
    }
}
