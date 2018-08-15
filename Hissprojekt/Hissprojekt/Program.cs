
using System;

namespace Hissprojekt
{
    class Program
    {
        static void Main(string[] args)
        {


            var s = new System.Collections.Generic.List<string>();

            Header("SKAPAR HISSEN KALLE");
            var hiss1 = new Elevator("Kalle", -2, 10, 5, 2);

            Console.WriteLine("     " + hiss1.Report());
            Info("Signal till Kalle att åka upp en våning");
            hiss1.GoUp();
            Console.WriteLine("     " + hiss1.Report());

            Info("Signal till Kalle att åka upp en våning");
            hiss1.GoUp();
            Console.WriteLine("     " + hiss1.Report());

            Info("Signal till Kalle att åka upp en våning");
            hiss1.GoUp();
            Console.WriteLine("     " + hiss1.Report());

            // Test av Lisa (hissen är redan på lägsta nivå så kommer inte åka nånstans)

            Console.WriteLine();
            Header("SKAPAR HISSEN LISA");
            var hiss2 = new Elevator("Lisa", 5, 8);

            Console.WriteLine("     " + hiss2.Report());
            Info("Signal till Lisa att åka ner en våning");
            hiss2.GoDown();
            Console.WriteLine("     " + hiss2.Report());
        }

        private static void Info(string v)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(v);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(v);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }


}


