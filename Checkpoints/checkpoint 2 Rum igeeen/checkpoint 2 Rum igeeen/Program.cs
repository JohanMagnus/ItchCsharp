using System;
using System.IO;
using System.Collections.Generic;



namespace checkpoint_2_Rum_igeeen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vardagsrum 40m2 | Toa 5m2 | Kök 6m2 | Hall 10 m2
            //AskForUserInput();

            Console.WriteLine("Ange namn på rum: ");
            string input = Console.ReadLine();
            string[] listArray = input.Split('|');
           
            var allRooms = new List<Room>();
            foreach (var item in listArray)
            {
                var room = new Room();

                string[] pair = item.Trim().Split(' ');
                string nameOfRoom = pair[0];
                string sizeOfRoom = pair[1].Replace("m2", "");

                room.RoomName = nameOfRoom;
                room.RoomArea = int.Parse(sizeOfRoom);

                allRooms.Add(room);
            }

            int counter = 0;

            foreach (var room in allRooms)
            {
                counter++;

                Console.WriteLine("*Rumnamn " + counter +   room.RoomName);
            }

            string biggestRoom = "";
            int sizeOfBiggestRoom = 0;
            foreach (var room in allRooms)
            {
                if(sizeOfBiggestRoom < room.RoomArea)
                {
                    sizeOfBiggestRoom = room.RoomArea;
                    biggestRoom = room.RoomName;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Det största rummet är " + biggestRoom);


        }

      

       
    }
}
