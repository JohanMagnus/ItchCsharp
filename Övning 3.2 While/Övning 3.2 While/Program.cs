using System;

namespace Övning_3._2_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Times to repeat: ");
            int repeat = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;


            //for (int i = 0; i < repeat; i++)
            //{
            //    Console.WriteLine("Your name is " + name);
            //}

            //int i = 0;
            //while (i < repeat)
            //{
            //    Console.WriteLine("Your name is " + name);
            //    i++; 

            //    string placeholders = string.Format("Your name is {0}", name);
            //    Console.WriteLine(placeholders);
            //}
            int i = 0;
            while(true)
            {
                Console.WriteLine("Your name is " + name);
                
                i++;

                if ( i == repeat )
                {
                    break;
                }
          

            }



        }
    }
}
