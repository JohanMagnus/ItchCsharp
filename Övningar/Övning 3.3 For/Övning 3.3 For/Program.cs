using System;

namespace Övning_3._3_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Time to repeat: ");
            int repeat = int.Parse(Console.ReadLine());

            var reverse = name.Remove(14);
            Console.WriteLine(reverse);

            //var trimmedResult = name.Trim();
            //var trimLeading = name.TrimStart();
            //var trimTrailing = name.TrimEnd();
            //var stora = name.ToUpper();

            //Console.WriteLine(trimmedResult);
            //Console.WriteLine(trimLeading);
            //Console.WriteLine(trimTrailing);
            //Console.WriteLine(stora);



            //Console.Write("How many rows? ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("How many columns? ");
            //int columns = int.Parse(Console.ReadLine());


            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine("Your name is " + name);
            }


        }
    }
}
