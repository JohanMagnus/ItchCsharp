using System;

namespace Övning_3._5_Foreach_with_break
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter name in a list: ");
            string names = Console.ReadLine();
            string[] array = names.Split(", ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();


            foreach (var item in array)
            {
                Console.WriteLine(item + " Andersson");
                



                if (item == "Zelda")
                {
                    if (item == "AllowZelda")
                    { return; }
                    break;
                }




            }


        }
    }
}
