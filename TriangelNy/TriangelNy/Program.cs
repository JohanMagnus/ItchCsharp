using System;

namespace TriangelNy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange kommando: ");
            string answer = Console.ReadLine();
            string[] list = answer.Split("-");

            foreach (var item in list)
            {
                int tal = int.Parse(item);
                for (int i = 0; i < tal; i++)
                {
                    Console.Write("*");
                }

            }

            
        }
    }
}
