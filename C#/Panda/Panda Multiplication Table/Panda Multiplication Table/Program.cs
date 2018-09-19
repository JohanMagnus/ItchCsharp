using System;

namespace Panda_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table");

            int[] list = new int[12];
            for (int i = 0; i < list.Length ; i++)
                list[i] = i + 1; 
            
            // { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            
            //int[] list2 = { 1, ... , 12 };

            foreach (var item in list)
            {
                for (int i = 1; i <= 12; i++)
                {
                    int result = item * i;
                    Console.WriteLine($"{item} * {i} = {result}");
                }
                Console.WriteLine();
            }

            //Count();
        }

        //private static void Count()
        //{
        //    for (int i = 1; i < 12; i++)
        //    {
        //        for (int j = 0; j < 12; j++)
        //        {
        //            Console.WriteLine($"{i} * {j} = {i*j}");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
