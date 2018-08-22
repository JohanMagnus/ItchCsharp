using System;
using System.Collections.Generic;

namespace Håkan
{
    class NameNumber
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // newNumber = (i < 3) ? list[i] + 50 : list[i]; (Villkor ? UtfallOmSant : UtfallOmFalskt)

            List<string> listOfString = new List<string> { "Rezan, 7", "Johan, 8", "Isabelle, 9" };
            var FinalList = new List<NameNumber>();


            foreach (string item in listOfString)
            {
                string[] splittedString = item.Split(',');
                NameNumber nn = new NameNumber();

                nn.Name = splittedString[0];
                nn.Number = int.Parse(splittedString[1]);

                FinalList.Add(nn);
            }

            foreach(var item in FinalList)
            { 
                Console.WriteLine($"{item.Name} {item.Number}");
            }

        }
    }
}
