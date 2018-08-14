using System;

namespace ForFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int a = 1; a <= 2; a++)
            //{
            //    for (int b = 1; b <= 3; b++)
            //    {
            //        Console.WriteLine(a + " " + b);
            //    }
            //}

            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    Console.WriteLine(a + " " + b);
                }
            }

            Console.WriteLine("Skriv in namn: ");
            string names = Console.ReadLine();
            string[] list = names.Split(", ");

            //Console.WriteLine("Skriv in nummer: ");
            //string numbers = Console.ReadLine();
            //string[] listNumbers = numbers.Split();
            //Console.WriteLine("Du skrev in följande namn: ");

            //int counter = 0;

            //foreach (var item in list)
            //{
                
            //    Console.WriteLine(item);
            //}
           



        }
    }
}
