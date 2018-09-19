using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToString
    {

        public void Run()
        {

            /*
            
                Returnera en text som talar om vilket det första och sista numret är i listan

                string result = ReportFirstAndLastValue(new List<int> {5, 1000, 2000, 3000, 6});

                ==>    Första siffran är 5 och sista siffran är 6
             */

            //string result = ReportFirstAndLastValue(new List<int> { 5, 1000, 2000, 3000, 6 });
            //Console.WriteLine(result);

            /*
             
                Returnera en text som säger om alla nummer är högre än 100 eller inte.

                string result = ReportIfAllValuesAreHigherThan100(new List<int> {200, 105, 150});
                ==>    Alla nummer är högre än 100

                string result = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 98, 150 });
                ==>    Något nummer är lägre än 100

             */
            string result = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 105, 500});
            Console.WriteLine(result);

            /*
                Returnera en text hur många negativa tal som finns i listan

                string result = ReportNumberOfNegativeValues(new List<int> {5, 7, -2, 100, -4});
                ==>     Det finns 2 st negativa tal i listan

                string result = ReportNumberOfNegativeValues(new List<int> { 5, 7, 44, 100, 33 });
                ==>     Jippi! Det finns inga negativa tal i listan
             */
            string kalle = ReportNumberOfNegativeValues(new List<int> { 5, 7, 2, -100, 4 , 17, 18});
            Console.WriteLine(kalle);

            //Console.WriteLine("RESULT");
            //Console.WriteLine(result);

        }

        private string ReportNumberOfNegativeValues(List<int> list)
        {
            var FinalList = new List<int>();
            foreach (var item in list)
            {
                if (item < 0)
                    FinalList.Add(item);
            }
            if (FinalList.Count == 0)
                return "Jippi, inga negativa tal";
            
            else
                return "Det finns " + FinalList.Count + " negativa tal i listan";



        }

        private string ReportIfAllValuesAreHigherThan100(List<int> list)
        {
            var FinalList = new List<int>();

            int number = 100;
            foreach (int item in list)
            {
                if (item > number)
                {
                    FinalList.Add(item);
                }
                    
            }

            if (FinalList.Count == list.Count)
                return "Alla nummer är högre än " + number;
            else
                return " Något nummer är lägre än " + number;
            

        }

        private string ReportFirstAndLastValue(List<int> list)
        {
            
            int  x = list[0];
            int  y = list[list.Count - 1];

            // finalList.Add(x);
            // finalList.Add(y);

            return "Försts siffran är " + x + "och sista siffran är " + y;
            

        }
    }
}