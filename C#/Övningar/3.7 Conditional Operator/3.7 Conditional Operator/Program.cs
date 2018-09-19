using System;

namespace _3._7_Conditional_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int number = int.Parse(Console.ReadLine());

            int compare = 20;

            string classify;

            Console.ForegroundColor = ConsoleColor.Green;

            classify = (number > compare) ? "Higher than " + compare : (number == 20) ? "Equal to" + compare : "Lower than " + compare;
            Console.WriteLine(classify);
        }
    }
}
