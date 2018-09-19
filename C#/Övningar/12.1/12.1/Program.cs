using System;
using System.Collections.Generic;

namespace _12._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] rockstarsArray = new string[]{ "Jim Morrison", "Ozzy Osbourne", "David Bowie", "Jimmy Hendrix" };
            List<string> rockstarlist = new List<string> { "Jim Morrison", "Ozzy Osbourne" , "David Bowie", "Jimmy Hendrix" };

            DisplayArrayOfRockStars(rockstarsArray);
            DisplayListOfRockStars(rockstarlist);
            DisplayListOfRockStars2(rockstarsArray);
            DisplayListOfRockStars2(rockstarlist);
            DisplayListOfRockStars3(rockstarlist);
            RemoveFirstRockStar(rockstarsArray);



        }

        private static void DisplayListOfRockStars2(IEnumerable<string> b)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("My rockstars: (IEnumerable)");
            foreach (var item in b)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    

        private static void DisplayArrayOfRockStars(string[] a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("My rockstars: (array)");
            foreach (var item in a)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        private static void DisplayListOfRockStars(List<string> rockstars)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("My rockstars: (list)");
            foreach (var rockstar in rockstars)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(rockstar  );
            }
            Console.WriteLine();
        }
        private static void DisplayListOfRockStars3(IEnumerable<object> b)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("My rockstars: (object)");
            foreach (var item in b)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
        private static void RemoveFirstRockStar(IEnumerable<string> rockstars)
        {
            
        }


    }
}
