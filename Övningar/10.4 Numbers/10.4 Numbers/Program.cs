using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number: ");
                Console.ForegroundColor = ConsoleColor.Green;
                int input = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;
                numbers.Add(input);


                if (input == 0)
                    break;

            }

            int result = CalculateSum(numbers);
            Console.WriteLine(result);

            //foreach (var item in numbers)
            //{

            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine($"Name: {item}");

            //}


        }


        static int CalculateSum(List<int> numbers)
        {

            int sum = 0;

            foreach (var item in numbers)
            {
                sum = item + sum;

            }
            return sum;
        }
    }
}
