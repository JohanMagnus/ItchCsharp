using System;

namespace Omprov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange kommando: ");
            string kommando = Console.ReadLine();
            string[] list = kommando.Split("-");

            foreach (var item in list)
            {
                int rad = int.Parse(item);

                for (int i = 0; i < rad; i++)
                {
                    for (int j = 0; j < rad; j++)
                    {
                        Console.Write("O");
                        Console.Write("");
                    }
                    Console.WriteLine();
                    
                }

                

                
                Console.WriteLine();

            }

            
        }
    }
}
