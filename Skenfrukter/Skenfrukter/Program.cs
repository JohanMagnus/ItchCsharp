using System;
using System.Collections.Generic;

namespace Skenfrukter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rensa databasen + lägg in några frukter kopplade till olika kategorier

            ClearAndInitDatabase();

            // Visa alla frukter

            DisplayAllFruits();

            // Visa bara skenfrukter

            DisplayJustSkenfrukter();

            DisplayBaskets();

            Console.ReadKey();
        }

        private static void DisplayBaskets()
        {
            var dataAccess = new DataAccess();
            List<Basket> baskets = dataAccess.GetAllBaskets();
            foreach (var b in baskets)
            {
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("VARUKORG: " + b.Name);
                Console.WriteLine();

                List<Fruit> fruits = dataAccess.GetAllFruitsInBasket(b.Id);
                foreach (var f in fruits)
                {
                    Console.WriteLine(f.Name);
                }

            }
        }

        private static void ClearAndInitDatabase()
        {
            var dataAccess = new DataAccess();
            dataAccess.ClearDatabase();
            dataAccess.AddCategoriesAndFruits();
            dataAccess.SaveChanges();
        }

        private static void DisplayAllFruits()
        {
            var dataAccess = new DataAccess();
            foreach (Fruit x in dataAccess.GetAll())
            {
                Console.WriteLine(x.Id.ToString().PadRight(5) + x.Name.PadRight(20) +
                                  x.Price.ToString().PadRight(10) + x.Category?.Name.PadRight(10));
            };
        }

        private static void DisplayJustSkenfrukter()
        {
            var dataAccess = new DataAccess();
            List<Fruit> fruits = dataAccess.GetFruitsInCategory("Skenfrukt");
            Console.WriteLine();
            Console.WriteLine("SKENFRUKTER");
            Console.WriteLine();
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit.Name);
            }
        }
    }
}


