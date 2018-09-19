using System;

namespace Övning_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Fruit 1:");
            string fruit1 = Console.ReadLine();

            Console.Write("Enter Fruit 2:");
            string fruit2 = Console.ReadLine();

            Console.Write("Enter Fruit 3:");
            string fruit3 = Console.ReadLine();

           //Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Green;
   
            Console.WriteLine("You entered three fruits:" + fruit1 + "," + fruit2 + ";" + fruit3);

            string placeholders = string.Format("You enterered three fruits:  {0}, {1}, {2}!", fruit1, fruit2, fruit3);
            Console.WriteLine(placeholders);
            
            string inter = $"You entered three fruits: {fruit1}, {fruit2}, {fruit3}";
            Console.WriteLine(inter);

        }
    }
}
