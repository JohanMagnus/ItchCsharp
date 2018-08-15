using System;

namespace _6._4_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Person
        {
            public string FirstName { get; set; }
            public string  LastName { get; set; }
            public DateTime BirthDay { get; set; }
            public string Gender { get; set; }
            public string  FavouriteSport { get; set; }


        }

        enum FavouriteSport
        {
            Tennis, Rugby, Hurling, Soccer, Squash
        }

        enum Gender
        {
            Female, Male, Other
        }

    }
}
