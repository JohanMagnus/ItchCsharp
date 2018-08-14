using System;

namespace Elementary_3
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("What is your name? ");
                string name = Console.ReadLine();

                if (name == "Alice" || name == "Bob")
                {
                    Console.WriteLine("Hello " + name);
                    break;
                }
                else
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your name is " + name);
                    break;
            }
        }
    }
}
