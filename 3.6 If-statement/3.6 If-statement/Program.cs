using System;

namespace _3._6_If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Which number to compare to?");
            int compare = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;

            if (number > compare)
            {
                if (number == compare)
                {
                    Console.WriteLine("Equal to " + compare);
                }
                Console.WriteLine("Higher than " + compare);
            }
            else
            {
                if (number == compare)
                    Console.WriteLine("Equal to " + compare);
                else
                Console.WriteLine("Lower than " + compare);
            }
        }
    }
}
