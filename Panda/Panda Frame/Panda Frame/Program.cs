using System;

namespace Panda_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello World in a frame
            Console.WriteLine("Which phrase do you want to print in a frame?");
            string input = Console.ReadLine();
            string[] list = input.Split(' ');

           
            int lengthLongestWord = 0;
            foreach (var word in list)
            {
                if (lengthLongestWord < word.Length)
                {
                    
                    lengthLongestWord = word.Length;

                }
            }
            
            PrintFirstAndLastLine(lengthLongestWord);
            
            Console.WriteLine();
            int counter = -1;
            for (int i = 0; i < list.Length; i++)
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                counter++;
                Console.WriteLine($"** {list[counter].PadRight(5)} **");

            }

            PrintFirstAndLastLine(lengthLongestWord);
            Console.ResetColor();
            Console.WriteLine();
 
        }

        private static void PrintFirstAndLastLine(int lengthLongestWord)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int j = 0; j < lengthLongestWord + 6; j++)
            {
                Console.Write("*");
            }
        }
    }
}
