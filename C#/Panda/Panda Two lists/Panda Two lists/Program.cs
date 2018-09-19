using System;
using System.Collections.Generic;

namespace Panda_Two_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers:");
            string numbers = Console.ReadLine();
            Console.WriteLine("Enter letters: ");
            string letters = Console.ReadLine();

            string[] listNumbers = numbers.Split(' ');
            string[] listLetters = letters.Split(' ');

            List<string> stringLista = CombineTwoLists(listNumbers, listLetters);

            foreach (var item in stringLista)
            {
                Console.Write(item);
            }
      

        }

        private static List<string> CombineTwoLists(string[] listNumbers, string[] listLetters)
        {
            List<string> result = new List<string>();
            for (int i = 0; i <listNumbers.Length ; i++)
            {
                var x = listNumbers[i];
                var y = listLetters[i];

                result.Add(x);
                result.Add(y);

            }
            return result;
        }
    }
}
