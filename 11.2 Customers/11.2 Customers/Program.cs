using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _11._2_Customers
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int Age  { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("ListaPersoner2.txt");
            var allCustomers = new List<Customer>();

            foreach (var line in allLines)
            {
                var splittedLine = line.Split(',');
                var firstname = splittedLine[1];
                var lastname = splittedLine[2];
                var email = splittedLine[3];
                var gender = splittedLine[4];
                var age = splittedLine[5];

                var Customer = new Customer();
                Customer.FirstName = firstname;
                Customer.LastName = lastname;
                Customer.Email = email;
                Customer.Gender = gender;
                Customer.Age = int.Parse(age);

                allCustomers.Add(Customer);
            }

            Header("Sorted list by age");
          
            foreach (var Customer in allCustomers.OrderBy(x => x.Age))
            {
                Console.WriteLine(Customer.FirstName.PadRight(19) +  Customer.Age);
            }
            Header("Sorted list by name");

            foreach (var Customer in allCustomers.OrderBy(x => x.FirstName))
            {
                Console.WriteLine(Customer.FirstName.PadRight(19) + Customer.Age);
            }

            var olderthan35 = new List<Customer>();
            foreach (var Customer in allCustomers)
            {
                if (Customer.Age>35)
                {
                    olderthan35.Add(Customer);
                }

            }
            Header("Older than 35");
            foreach (var Customer in olderthan35)
            {
                Console.WriteLine(Customer.FirstName.PadRight(19)  + Customer.Age);
            }
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(v);
            Console.ResetColor();
        }
    }
}
