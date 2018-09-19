using System;

namespace _8._3_Animals_in_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of animals: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            string[] list = input.Split(", ");

            TestString(list);
  
        }

        private static void TestString(string[] list)
        {


            foreach (var item in list)
            {
                if (item.Length > 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" {item} has too many letters");
                }


            }

            if (list.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Animal string dont contain any letters");
            }

            foreach (var item in list)
            {
                if (item == " ")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("One of the animals didnt contain any letter");
                }

            }
            //foreach (var item in list)
            //{
            //    if (item.Contains)
            //    {

            //    }
            //}

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"There are {list.Length} animals in the list");
        }
        
    }
}
