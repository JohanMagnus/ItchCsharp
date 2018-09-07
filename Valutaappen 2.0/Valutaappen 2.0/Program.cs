using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Valutaappen_2._0.Domain;

namespace Valutaappen_2._0
{
    class Program
    {
        

        static void Main(string[] args)
        {

            for (int i = 1; i < 50; i++)
            {
                Console.SetWindowSize(3 * i, i);
                System.Threading.Thread.Sleep(200);
            }

            string Progresbar = "This is a currency converter";
            var title = "";
            while (true)
            {
                for (int i = 0; i < Progresbar.Length; i++)
                {
                    title += Progresbar[i];
                    Console.Title = title;
                    Thread.Sleep(100);
                }
                title = "";
                Console.Clear();

                //GetDataAccess dataaccess = new GetDataAccess();

                GetAPI api = DownloadPageAsync().Result;

                //dataaccess.InsertIntoSQL(api);


                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Välkommen till Valutaappen, glöm inte papper och penna");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("A) Se alla valutor i världen med EURO som bas");
                Console.WriteLine("B) Konvertera en valfri valuta");
                Console.WriteLine("C) Avsluta appen");

                
                var command = Console.ReadKey().Key;
                if (command == ConsoleKey.C)
                    break;
                switch (command)
                {
                    case ConsoleKey.A: ShowAllRates(); break;
                    case ConsoleKey.B: ConvertRates(); break;
                    
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

       
        private static void ConvertRates()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Skriv in vilken valuta du vill konvertera, använd valutakoden: ");
            Console.ResetColor();
            string valuta = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Vilken valuta vill du konvertera till: ");
            Console.ResetColor();
            string valuta2 = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Hur mycket vill du konvertera: ");
            Console.ResetColor();
            decimal money = decimal.Parse(Console.ReadLine());

            GetDataAccess dataaccess = new GetDataAccess();
            dataaccess.GetConvertRates(valuta, valuta2, money);

            Console.ReadKey();
            Console.Clear();

        }

        

        private static void ShowAllRates()
        {
            GetDataAccess dataaccess = new GetDataAccess();
            List<Currency> allRates = dataaccess.GetAllRates();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nFörkortning".PadRight(21) + "Land".PadRight(30) + "Växelkurs mot Euro\n".PadRight(30));
            Console.ResetColor();

            int counter = 0;
            foreach (var item in allRates)
            {
                counter++;  
                Console.WriteLine(item.Code.PadRight(20) + item.Name.PadRight(30) + item.Rate.ToString().PadRight(30));
                if (counter == 25)
                    Console.ReadKey();
            }

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
                
                    //Console.WriteLine(result + "...");

                GetAPI api = new GetAPI();

                api = JsonConvert.DeserializeObject<GetAPI>(result);

                var stringArray = api.Rates.ToString().Split(',');
                List<Currency> currencies = new List<Currency>();

                foreach (var row in stringArray)
                {
                   var currency = new Currency();
                    string[] split = row.Trim().Split(':');
                    string stringOfCode = split[0].Replace("\"","").Replace("\r\n", "").Replace("{", "").Trim();
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
