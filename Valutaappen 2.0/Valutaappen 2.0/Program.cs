﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Valutaappen_2._0.Domain;

namespace Valutaappen_2._0
{
    class Program
    {
        

        static void Main(string[] args)
        {
            GetDataAccess dataaccess = new GetDataAccess();
            //Task<string> t = new Task<string>(DownloadPageAsync);
            //t.Start();

            GetAPI api = DownloadPageAsync().Result;
            Console.WriteLine("Downloading page...");
            Console.WriteLine("Getting Data...");
            

           dataaccess.InsertIntoSQL(api);
        

        }

        static async Task<GetAPI> DownloadPageAsync()
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

                GetAPI api = new GetAPI();

                api = JsonConvert.DeserializeObject<GetAPI>(result);

                var stringArray = api.Rates.ToString().Split(',');
                List<Currency> currencies = new List<Currency>();

                foreach (var row in stringArray)
                {
                   var currency = new Currency();
                    string[] split = row.Trim().Split(':');
                    string stringOfCode = split[0].Replace("\"","");
                    decimal stringOfRate = decimal.Parse(split[1].Replace('.', ',').Replace("\r\n", "").Replace("}", ""));
                    currency.Code = stringOfCode;
                    currency.Rate = stringOfRate;

                    currencies.Add(currency);

                }

                api.Currencies = currencies;

                return api;
                



            }
            




        }
    }
}
