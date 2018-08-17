using System;
using System.Collections.Generic;
using System.IO;


namespace Checkpoint_provar_igen_
{
    class Room
    {
        public string  Name { get; set; }
        public int Area { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("Texten.txt");
            var allRooms = new List<Room>();

            Console.WriteLine(allLines);

            foreach (var item in allLines)
            {
                var splittedLine = item.Split('|');
                var object1 = splittedLine[0];

                var room = new Room();

                room.Name = object1;

                allRooms.Add(object1);



                    
            }

            Console.WriteLine(allRooms);

            


        }
    }
}
