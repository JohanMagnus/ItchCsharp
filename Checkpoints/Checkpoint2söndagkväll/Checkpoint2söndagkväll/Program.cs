using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint2söndagkväll
{
    class Program
    {
        static void Main(string[] args)
        {
            AskForUserInput();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ange namn på rum:");
            Console.ForegroundColor = ConsoleColor.Gray;
            string input = Console.ReadLine();
            //Vardagsrum 40m2 | Toa 5m2 | Kök 6m2 | Hall 10m2
            Console.ForegroundColor = ConsoleColor.Gray;
            string[] listArray = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            var allRooms = new List<Room>();

            foreach (var item in listArray)
            {
                var room = new Room();
                string[] pair = item.Trim().Split(' ');
                string nameOfRoom = pair[0];
                string sizeOfRoom = pair[1].Replace("m2", "");

                room.Name = nameOfRoom;
                room.Area = int.Parse(sizeOfRoom);

                allRooms.Add(room);
        
            }

            int counter = 0;
            foreach (var room in allRooms)
            {
                counter++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*Rumnamn " + counter + ": " + room.Name);
            }

            //Skriv ut största rummet. 

            // Room detStörsta = allRooms.OrderByDescending(x => x.Area).First();
            // Console.WriteLine("Det största rummet är " + detStörsta.Name);

            string biggestRoom = "";
            int sizeOfBiggestRoom = 0;

            foreach (var room in allRooms)
            {
                if (room.Area > sizeOfBiggestRoom)
                {
                    biggestRoom = room.Name;
                    sizeOfBiggestRoom = room.Area;
                }
            }

            Console.WriteLine("Det största rummet är " + biggestRoom);


        }

        private static void AskForUserInput()
        {
            
        }
    }
}
