using System;

namespace _8._1_Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            try
            {
                    Console.ForegroundColor = ConsoleColor.White;
                decimal pieces = 24M;
                Console.Write($"The chocolate contains {pieces} pieces");
                Console.WriteLine();


                Console.Write("How many want to share? ");
                Console.ForegroundColor = ConsoleColor.Green;
                decimal share = decimal.Parse(Console.ReadLine());

                decimal result = pieces / share;

                Console.WriteLine($"Everyone gets {result:.##} pieces");
                    break;
            }
            catch (DivideByZeroException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zero people cant divide a chocolate");
                   
            }
            catch (FormatException)
            {
                    Console.WriteLine();
            }
            
        }
    }
}
