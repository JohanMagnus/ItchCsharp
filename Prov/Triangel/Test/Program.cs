using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int i, j, k;
            for (i = 1; i <= number; i++)
            {
                for (j = 1; j <= number - i; j++)
                {
                    Console.Write("");
                }

                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
        }
    }
}
