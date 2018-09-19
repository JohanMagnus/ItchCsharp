using System;
using System.IO;

namespace _6._4_Enum__igen_
{
   
    class Program
    {
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Birthday { get; set; }
            public Gender Gender { get; set; }
            public Sport FavouriteSport { get; set; }
        }

        enum Sport
        {
            Tennis, Rugby, Soccer, Hurling, Squash
        }

        enum Gender
        {
            Female, Male, Other
        }
        static void Main(string[] args)
        {
            //var list = new Person
            //{
            //    FirstName = "Lisa",
            //    Gender = Gender.Female
            //};

            Person Lisa = new Person
            {
                FirstName = "Lisa",
                LastName = "Smith",
                Gender = Gender.Female,
                Birthday = "9 februari",
                FavouriteSport = Sport.Hurling,
            };

            Console.WriteLine(Lisa.FirstName.ToLower() + " is a " + Lisa.Gender);
            Console.WriteLine(Lisa.FirstName + Lisa.LastName + " likes " + Lisa.FavouriteSport);


            Console.WriteLine(Lisa.FirstName + " dont like to play " + Lisa.FavouriteSport);

            Console.WriteLine("Here is a list of all enum Sports: ");
            foreach (string Sport in enum.GetNames)
            {
            Console.WriteLine();
            }
            
        }
    }
}
