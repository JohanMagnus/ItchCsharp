using System;

namespace Övning_3._4_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name in a list(like Maria, Peter, etc: ");
            string names = Console.ReadLine();
            Console.Write("What surname?");
            string lastname = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;


            var list = names.Split(";");
            
            foreach (var item in list)
            {
                Console.WriteLine(item + lastname);

                if (item == "Zelda") ;
                break;


            }

  
            

        }
    }
}
