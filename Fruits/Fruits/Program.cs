using System;
using System.Linq;

namespace Fruits
{
    class Program
    {
        static FruitContext context = new FruitContext();

        static void Main(string[] args)
        {
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            AddFruits();
            DisplayFruits();

        }

        private static void DisplayFruits()
        {

            foreach (var fruit in context.fruits1.OrderByDescending(x => x.Name))
            {
                Console.WriteLine(fruit.Id + "  " + fruit.Name.PadRight(15) + "  " + fruit.Price);
            }
        }

        private static void AddFruits()
        {

            var f = new Fruit
            {
                Name = "Banan",
                Price = 12.9M

            };
            context.fruits1.Add(f);

            context.Add(new Fruit

            {
                Name = "Päron",
                Price = 8
            });


            context.SaveChanges();
        }
    }
}
