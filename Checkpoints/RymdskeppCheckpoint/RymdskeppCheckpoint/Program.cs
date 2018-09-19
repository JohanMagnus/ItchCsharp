using System;
using System.Collections.Generic;
using System.Linq;

namespace RymdskeppCheckpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            RecreateDatabase();

            AddSpaceship("USS Enterprize");
            AddSpaceship("Millenium Falcon");
            AddSpaceship("Cylon Raider");

            List<Spaceship> spaceList = GetAllSpaceships();
            DisplayAllSpaceships(spaceList);

            AddRavioliForSpaceship("Cylon Raider", 1, "2018-04-19");


        }

        private static void AddRavioliForSpaceship(string ship, int numberOfCans, string date)
        {
            var context = new SpaceContext();

            Spaceship spaceship = context.Spaceships.Where(x => x.Name == ship).SingleOrDefault();
            //if (spaceship == null)
            //    DoNothing();
            //else
            //{
            //    var spaceShip = new Spaceship
            //    { Name = ship,


            //    };

            //    using (var context = new SpaceContext())
            //    {
            //        context.Spaceships.Add(spaceShip);
            //        context.SaveChanges();

            //    }
            //}

                

        }

        private static void DoNothing()
        {
            Console.WriteLine("Här slutar resan");
        }

        private static void DisplayAllSpaceships(List<Spaceship> spaceList)
        {
            int counter = 0;
            foreach (var spaceship in spaceList)
            {
                counter++;
                Console.WriteLine($"{counter}    {spaceship.Name.PadRight(10)}");
            }
        }

        private static List<Spaceship> GetAllSpaceships()
        {
            var context = new SpaceContext();
            var list = new List<Spaceship>();

            foreach (var spaceship in context.Spaceships)
            {
                list.Add(spaceship);
            }

            return list;
            
        }

        private static void AddSpaceship(string v)
        {
            var spaceShip = new Spaceship
            { Name = v };

            using (var context = new SpaceContext())
            {
                context.Spaceships.Add(spaceShip);
                context.SaveChanges();

            }
        }

        private static void RecreateDatabase()
        {
            using (var context = new SpaceContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
