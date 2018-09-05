using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace Valutaappen_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(DownloadPageAsync);
            t.Start();
            Console.WriteLine("Downloading page...");
            Console.ReadLine();
            //DownloadPageAsync();
        }

        static async void DownloadPageAsync()
        {
            // ... Target page.
            string page = "http://data.fixer.io/api/latest?access_key=e241cb375d68ed80e30793039b2bbed4&format=1";

            // ... Use HttpClient.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                string result = await content.ReadAsStringAsync();
                // Console.WriteLine(result.Substring(0,50));
                // ... Display the result.
                //if (result != null &&
                //    result.Length >= 50)
                
                    Console.WriteLine(result + "...");
                
            }
        }
    }
}
