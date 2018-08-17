using System;
using System.Collections.Generic;

namespace Checkpoint2_Fredag17aug
{

    class Room
    {
        public string Name { get; set; }
        public int Area { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
             var list = new List<Room>();
            // AskForUserInput();
            Console.WriteLine("Ange namn på rum:");
            var input = Console.ReadLine();
            //string[] list = input.Split("|");

            foreach (var item in input)
            {
                var splittedLine = input.Split(',');
                var name = splittedLine[0];
                var area = splittedLine[1];

                var room = new Room();
                room.Name = name;
                room.Area = int.Parse(area);
            }





            // string[] list = input.Split("|");





        }

        //private static void AskForUserInput()
        //{
        //    Console.WriteLine();
        //}
    }
}
