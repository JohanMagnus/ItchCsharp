using Kiosk.Domain;
using System;
using System.Collections.Generic;

namespace Kiosk
{
    internal class App
    {
        DataAccess dataaccess = new DataAccess();

        internal void Run()
        {
            PageMainMenu();
        }

        private void PageMainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        Kiosk");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("A, Se lager");
            Console.WriteLine("B, Uppdatera lager");
            Console.WriteLine("C, Ta bort från laget");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Vad vill du göra? A, B, C");
            Console.ResetColor();
            ConsoleKey command = Console.ReadKey().Key;

            switch(command)
            {
                case ConsoleKey.A: SeeLayer();
                    break;
                case ConsoleKey.B: UpdateLayer();
                    break;
                case ConsoleKey.C: RemoveStuffFromLayer();
                    break;
            }
            Console.ReadKey();
            PageMainMenu();

        }

        private void RemoveStuffFromLayer()
        {
            throw new NotImplementedException();
        }

        private void SeeLayer()
        {
            List<Product> allProducts = dataaccess.GetAllProducts();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Dessa produkter finns i lagret:");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var item in allProducts)
            {
                Console.WriteLine(item.Id.ToString().PadRight(10) + item.Name.PadRight(25) + item.Antal.ToString());
            }
            
        }

        private void UpdateLayer()
        {
            Console.Clear();

            SeeLayer();
            Console.Write("Skriv in vilken produkt som ska uppdateras");
            int productId = int.Parse(Console.ReadLine());

            Product product = dataaccess.GetProductById(productId);

            Console.WriteLine("Hur många finns i lagret? ");

            int newNumber = int.Parse(Console.ReadLine());
            product.Antal = newNumber;

            dataaccess.UpdateLayer(product);

            Console.WriteLine("Lagret uppdaterat.  Tryck på valfri knapp för att komma till huvudmenyn");
            Console.ReadKey();
            PageMainMenu();
        }
    }
}