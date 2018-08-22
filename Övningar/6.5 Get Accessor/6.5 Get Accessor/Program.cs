using System;

namespace _6._5_Get_Accessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var MinAdress = new Adress();
            MinAdress.StreetNumber = "33";
            MinAdress.Street = "Långa gatan";
            MinAdress.City = "Sundsvall";
            MinAdress.ZipCode = "111 22";



            Console.WriteLine("Street:            " + MinAdress.Street);
            Console.WriteLine("StreetNumber:      " + MinAdress.StreetNumber);
            Console.WriteLine("City:              " + MinAdress.City);
            Console.WriteLine("Zipcode:           " + MinAdress.ZipCode);
            Console.WriteLine("FullStreet:        " + MinAdress.GetFullStreet());
            Console.WriteLine("");
            Console.WriteLine("FullStreet2:       " + MinAdress.FullStreet);

            MinAdress.SetZipCode("222 11");
            MinAdress.SetZipCode("Hello");
            MinAdress.SetZipCode("12345");
            MinAdress.SetZipCode("222");


            Console.WriteLine("Zipcode:           " + MinAdress.ZipCode);


        }

        class Adress
        {
            public string Street;
            public string StreetNumber;
            public string City;
            public string ZipCode;
            public string GetFullStreet()
            {
                return Street + " " + StreetNumber;
            }
            public string FullStreet
            {
                get
                { return Street + " " + StreetNumber; }
            }

            
            public static bool SetZipCode(string z)
            {
                //if (z == "222 11")
                //    ZipCode = z;
                
                return Regex.IsMatch
            }


        }

        

    }
}
