using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Valutaappen
{
    

    class Program
    {
        static void Main()
        {
            Test();
            //Task t = new Task(DownloadPageAsync);
            //t.Start();
            //Console.WriteLine("Downloading page...");
            Console.ReadLine();
        }

        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        private static void Test()
        {
            Product product = new Product();

            product.Name = "Apple";
            product.Price = 3.99M;

            //string output = JsonConvert.SerializeObject(product);


            string output = "{\"Name\":\"Apple\",\"Price\":3.99}";


            //string output = "";
            // 
            
            //  "Name": "Apple",
            //  "ExpiryDate": "2008-12-28T00:00:00",
            //  "Price": 3.99,
            //  "Sizes": [
            //    "Small",
            //    "Medium",
            //    "Large"
            //  ]
            //}

            Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);
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

                // ... Display the result.
                if (result != null &&
                    result.Length >= 50)
                {
                    Console.WriteLine(result.Substring(0, 50) + "...");
                }
            }
        }
    }
}
