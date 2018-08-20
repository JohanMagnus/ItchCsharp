using System;
using System.IO;
using System.Collections.Generic;

namespace Checkpoint_2_omprov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange möbler: ");
            //Fåtölj,1584:Billy bokhylla,299:Kallax hyllserie,899:Klippan - soffan,1795

            string input = Console.ReadLine();
            string[] list = input.Split(':');

            var allFurnitures = new List<Furniture>();

            foreach (var item in list)
            {
                var furniture = new Furniture();
                string[] pair = item.Split(',');
                string nameOfFurniture = pair[0];
                string priceOfFurniture = pair[1];

                furniture.Name = nameOfFurniture;
                furniture.Price = int.Parse(priceOfFurniture);

                allFurnitures.Add(furniture);
            }


            string cheapestFurniture = "";
            int cheapestFurniturePrice = 1000000; //Japp, en miljon

            foreach (var furniture in allFurnitures)
            {
                if (furniture.Price < cheapestFurniturePrice)
                {
                    cheapestFurniturePrice = furniture.Price;
                    cheapestFurniture = furniture.Name;
                }
            }

            Console.WriteLine("Den billigaste produkten är "  + cheapestFurniture + " och den kostar " + cheapestFurniturePrice + " kr");

        }
    }
}
