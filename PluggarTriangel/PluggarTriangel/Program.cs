using System;

namespace PluggarTriangel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange kommando: ");
            string numbers = Console.ReadLine();

            string[] list = numbers.Split("-");


            foreach (var item in list)
            {
                int tal = int.Parse(item);
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
}
