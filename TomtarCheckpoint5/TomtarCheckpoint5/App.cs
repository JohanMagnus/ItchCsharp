using System;
using System.Collections.Generic;

namespace TomtarCheckpoint5
{
    internal class App
    {
        DataAccess dataAccess = new DataAccess();

        internal void Run()
        {
            List<string> gnomes = dataAccess.GetGnomesFromDatabase();
            DisplayGnomes(gnomes);

            List<Gnome> listOfGnomes = dataAccess.GetGnomesListFromDatabase();
            DisplayList(listOfGnomes);
        }

        private void DisplayList(List<Gnome> listOfGnomes)
        {
            //string sql = @"Select Name, Beard, Evil, Temper, Rase from Gnome";
            string name = "NAMN";
            string beard = "HAR SKÄGG";
            string evil = "ÄR OND";
            string temper = "TEMPERAMENT";
            string rase = "RAS";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@name.PadRight(10) + beard.PadRight(15) +
                                    evil.PadRight(10) + temper.PadRight(16)
                                    + rase.PadRight(10));
            Console.ResetColor();

            foreach (Gnome gnome in listOfGnomes)
            {
                Console.WriteLine(@gnome.Name.PadRight(10) + gnome.Beard.PadRight(15) + 
                                   gnome.Evil.PadRight(10) +gnome.Temper.ToString().PadRight(16)
                                   +gnome.Rase.PadRight(10));
            }
            Console.WriteLine();
        }

        private void DisplayGnomes(List<string> gnomes)
        {
            Console.WriteLine("TOMTAR");
            Console.WriteLine();
            foreach (var gnome in gnomes)
            {
                Console.WriteLine(gnome);
            }
            Console.WriteLine();
        }
    }
}