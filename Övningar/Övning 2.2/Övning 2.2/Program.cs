using System;

namespace Övning_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            //int NewAge = Convert.ToInt32(age);
            //int retire = 65 - NewAge;
            int retire = 65 - int.Parse(age); 


            



            Console.WriteLine("What is your favorite character?");
            string letter = Console.ReadLine();
            char character = char.Parse(letter);
            

            Console.Beep();




            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();


            Console.WriteLine("Your name is:" + name);
            Console.WriteLine("You have " + retire + " years until retirement");

            if (char.IsNumber(character))
            Console.WriteLine("You like numbers");
           else
                Console.WriteLine("You dont like numbers");
        }
    }
}
