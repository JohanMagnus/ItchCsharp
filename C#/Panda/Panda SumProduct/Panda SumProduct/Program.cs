using System;

namespace Panda_SumProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input number: ");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("Do you wish to adding the sum or the product of the sum? (A or P)");
                string letter = Console.ReadLine().ToUpper();

                if (letter == "A")
                {
                    int sum = 0;
                    for (int i = 0; i <= input; i++)
                    {
                        sum = sum + i;
                    }
                    Console.WriteLine(sum);

                }
                else if (letter == "P")
                {
                    int prod = 1;
                    for (int i = 1; i <= input; i++)
                    {
                        prod = prod * i;
                    }
                    Console.WriteLine(prod);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel input");
                    Console.ResetColor();
                }
            }




        }
    }
}
