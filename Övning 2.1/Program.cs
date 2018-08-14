using System;

namespace Övning_2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is your favorite letter?");
            string letter = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();



            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("------");
            Console.WriteLine("Thank you!");

            Console.WriteLine("Your name is:" + name);
            Console.WriteLine("You are " + age + " years old");
            Console.WriteLine("Your favorite letter is " + letter);
            Console.WriteLine("Your favorite animal is " + animal);








        }
    }
}
