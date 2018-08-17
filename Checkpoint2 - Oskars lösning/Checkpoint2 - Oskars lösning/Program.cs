using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Checkpoint2___Oskars_lösning
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
            //Vardagsrum 40m2 | Toa 5m2 | Kök 6 m2 | Hall 10m2
            //1. Läs in sträng
            // AskUserForInput();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ange namn på rum:");
            Console.ForegroundColor = ConsoleColor.Gray;
            string input = Console.ReadLine();

            // 2. Omvandla strängen till en lista
            string[] listArray = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);


            //3. Skapa en lista av Room. 
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

            //4. Skriv ut alla rum
            int counter = 0;
            foreach (var room in allRooms)
            {
                counter++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("* Rumnamn " + counter + ": " + room.Name);
            }


            //5. Skriv ut största rummet. 

            string biggestRoom = "";
            int biggestRoomSize = 0;

            foreach (var room in allRooms)
            {
                if (biggestRoomSize < room.Area)
                {
                    biggestRoomSize = room.Area;
                    biggestRoom = room.Name;

                }
            }
            Console.WriteLine();
            Console.WriteLine("Det största rummet är " + biggestRoom + " som har arean " + biggestRoomSize + " m2");

            Room detStörsta = allRooms.OrderByDescending(x => x.Area).First();

            Console.WriteLine("Största rummet är " + detStörsta.Name);

        }

        //private static void AskUserForInput()
        //{
                
        //    Console.WriteLine("Ange namn på rum:");
        //    string input = Console.ReadLine();
        //}
    }
}
