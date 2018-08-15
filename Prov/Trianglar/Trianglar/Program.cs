using System;

namespace Trianglar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange kommando: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string numbers = Console.ReadLine();

            string [] list = numbers.Split("-");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            int j, k;

            for (int i = 0; i <  list.Length; i++)
            {
                for (j = 1; j <= list.Length ; j++)
                {
                    Console.Write("");
                }

                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            //Triangle 

        }
    }
}
