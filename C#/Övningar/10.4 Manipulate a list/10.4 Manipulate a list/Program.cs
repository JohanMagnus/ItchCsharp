using System;
using System.Collections.Generic;

namespace _10._4_Manipulate_a_list
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();


            while(true)
            {
                Console.Write("Enter a name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Gray;
                names.Add(input);
                

                if (input == "quit")
                    break;
            }

            names.Sort();
            names.RemoveAt(0);
            names.RemoveAt(names.Count -2);
            names.RemoveAt(names.Count - 1);

            foreach (var item in names)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Name: {item.ToUpperInvariant()}");
                
            }
            
            







        }
    }
}
