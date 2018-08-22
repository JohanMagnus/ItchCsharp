using System;

namespace Panda_Print_sum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What number do you wish to get sum to? ");
            string input = Console.ReadLine();
            int number = int.Parse(input);


            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
               
                if (i % 3 == 0)
                    sum = sum + i;

                if (i % 5 == 0)
                    sum = sum + i;
      
            }
            Console.WriteLine();
            Console.WriteLine($"Summan av talen är {sum}");

        }
    }
}
