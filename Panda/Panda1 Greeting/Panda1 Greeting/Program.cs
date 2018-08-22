using System;

namespace Panda1_Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What  is your name? ");
                string input = Console.ReadLine();


                if (input == "Bob" || "Alice" == input)
                {
                    Console.WriteLine($" Hello {input}");

                    break;

                }

            }
        }
    }
}
