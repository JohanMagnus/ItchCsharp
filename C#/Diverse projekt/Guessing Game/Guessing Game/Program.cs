using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int secretNumber = 10;
            int guess = 6;
            int antal = 6 - guess;

            while (guess > 0)
            {

                Console.Write("Guess the number 1-100, 6 guesses");
                int number = int.Parse(Console.ReadLine());
                antal--;

                if (number == secretNumber)
                    Console.WriteLine("Du gissade rätt!");
                else
                {
                    Console.WriteLine("Fel, försök igen");
                    Console.WriteLine(" Du har" + antal + "försök kvar");
                }
            }

           

        }
    }
}
