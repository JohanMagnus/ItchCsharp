using System;

namespace PluggarTriangel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange kommando: ");
            string  number = Console.ReadLine();
            int tal = int.Parse(number);
         
            int rows = 1;
            for (int i = 0; i < tal; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write("*");

                }
                rows++;

                Console.WriteLine();
            }






        }
    }
}
