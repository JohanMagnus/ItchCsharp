using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TV_kanaler
{
    class Show
    {
        public string Channel { get; set; }
        public TimeSpan StartAt { get; set; }
        public string Title { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("TextFile1.txt");

            Console.WriteLine(allLines);
            var allShows = new List<Show>();

          
            foreach (var line in allLines)
            {
                var splittedLine = line.Split('*');
                var channel = splittedLine[0];
                var time = splittedLine[1];
                var title = splittedLine[2];

                var show = new Show();
                show.Title = title;
                show.Channel = channel;
                show.StartAt = TimeSpan.Parse(time);

                allShows.Add(show);
            }

            Header("Alla titlar");

            foreach (var show in allShows)
            {
                Console.WriteLine(show.Title);
            }
            Header("Alla Kanaler");
            foreach (var show in allShows)
            {
                Console.WriteLine(show.Channel);
            }

            var laterThan21 = new List<Show>();
            foreach (var show in allShows)
            {
                if (show.StartAt.Hours >= 21)
                {
                    laterThan21.Add(show);
                }

            }
            Header("Shower som startar senare än 21");
            foreach (var show in laterThan21)
            {
                WriteInfo(show);
            }

              // Console.WriteLine("Shower som startar senare än 21");
           
            // var kalle = allShows.Where(x => x.StartAt.Hours <= 21);
            //Header("Shower som startar senare än 21");
            //foreach (var show in allShows.Where(x => x.StartAt.Hours >= 21))
            //{
          
            //    WriteInfo(show);
            //}
        }
        
        private static void Header(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text.ToUpper());
            Console.ResetColor();
        }

        private static void WriteInfo(Show show)
        {
            Console.WriteLine(show.Channel.PadRight(10) + " " + show.StartAt + " " + show.Title.PadLeft(50));
        }

    }
}
