using System;

namespace Räknare2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            for (int i = 0; i <11; i++)
            {
                
                for (int j = 0; j < a; j++)
                {
                    Console.WriteLine("*");
                }
                a++;
                Console.WriteLine();
            }
        }
    }
}
