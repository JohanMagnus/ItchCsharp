using System;

namespace _8._1_Dividing_chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            int pieces = 24;
            Console.Write($"The chocolate contains {pieces} pieces");
            Console.WriteLine();
            
            Console.Write("How many want to share? ");
            Console.ForegroundColor = ConsoleColor.Green;
            int share = int.Parse(Console.ReadLine());

            decimal result = pieces / share;

            Console.WriteLine($"Everyone gets {result} pieces");
            


        }
    }
}
