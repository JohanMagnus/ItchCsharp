using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result1 = ReorderList(new List<string> { "a", "b", "c", "d", "e" }, new List<int> { 3, 2, 1, 5, 4 });
            //List<string> result1 = ReorderList(new List<string> { "a", "b", "c", "d" }, new List<int> { 3,1,4,2 });
            // List<string> result1 = ReorderList(new List<string> { "a", "b" }, new List<int> { 2,2 });



            List<int> finalList = MultipleBy100AndAdd3(new List<int> { 2, 8, 3, 11 });

            foreach (var item in result1)
            { Console.WriteLine(item); }

            //foreach (var item in finalList)
            //{ Console.WriteLine(item); }
        }

        private static List<string> ReorderList(List<string> stringList, List<int> positionList)
        {
            //var thrownList = new List<string>();
            //int index = 0;
            var kalle  = new List<string>();

            //string xxx = stringList[2];

            foreach (int position in positionList)
            {
                // item=3
                var x = stringList[position - 1];
                kalle.Add(x);

            }
            //for (int i = 0; i < positionList.Count; i++)
            //{
            //    stringList = stringList.OrderBy(x => positionList[i++]).ToList();
            //}
            return kalle;

        }

        private static List<int> MultipleBy100AndAdd3(List<int> list)
        {
            var addAndMultiple = new List<int>();

            foreach (int number in list)
            {
                int newNumber = (number * 100) + 3;
                addAndMultiple.Add(newNumber);
            }
            return addAndMultiple;
        }
    }
}
