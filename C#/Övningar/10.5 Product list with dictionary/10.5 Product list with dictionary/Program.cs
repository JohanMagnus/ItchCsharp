using System;
using System.IO;
using System.Collections.Generic;

namespace _10._5_Product_list_with_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> products = BuildProductDictionary();

            DisplayProductDictionary(products);

        }

        private static void DisplayProductDictionary(Dictionary<int, string> d)
        {
            
            foreach (var item in d)
            {
                Console.WriteLine("Product id is " + item.Key + " and name is " + item.Value);
            }
            
        }

        public static Dictionary<int, string> BuildProductDictionary()
        {
            var d = new Dictionary<int, string>();
            
            
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Enter product id and name: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                        break;
                    string a = input.Split(", ")[0];
                    int b = int.Parse(a);
                    string c = input.Split(", ")[1];

                
                    if (d.ContainsKey(b) == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"The product list already contains {b}");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    else


                        d.Add(b, c);
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input");
                    //Console.WriteLine(Ex);
                }
                catch (IndexOutOfRangeException Ex)
                {
                    Console.WriteLine(Ex);

                }
                


            } return d;

        }

         



            






        
    }
}
