using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToNumberList
    {
        public void Run()
        {
            // Demo: dubblera alla tal i listan
            // Demo: dubblera alla tal i listan. Hoppa över negativa tal.

            /*
                Addera 100 till varje siffra i listan

               

                ==> 105, 115, 123, 300
             */
            //List<int> result = Add100ToEachNumber(new List<int> { 5, 15, 23, 200 });

            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}
            /*
                Filtrera ut de tal som är högre än 1000
             
                List<int> result = GetNumbersHigherThan1000(new List<int>{1005, 6, 77, 200000, 666});

                ==> 1005, 200000
             */
            //List<int> result = GetNumbersHigherThan1000(new List<int> { 1005, 6, 77, 20000, 666 });

            //PrintList(result);


            /*
                
                Returnera de tal som är delbara med 5

                List<int> result = GetNumbersDividableByFive(new List<int> { 20, 5, 6, 7, 10 });

                ==> 20, 5, 10
             */

            //List<int> result = DivideEachNumberBy100(new List<int> { 300, 200, -500, 1000 });

            //PrintList(result);

            /*
                Dela alla tal i listan med 100

                

                ==> 3, 2, -5, 10
             */


            /*
                Negera alla tal i listan

                List<int> result = NegateEachNumber(new List<int> { 10, 20, -30, 40 });

                ==> -10, -20, 30, -40
             */

            /*
                Addera 50 till de tre första elementen i listan
             
                List<int> result = Add50ToFirstThreeElements(new List<int> { 6, 16, 23, 200,300 });

                ==> 56, 66, 73, 200, 300

                List<int> result = Add50ToFirstThreeElements(new List<int> { 6, 16});
                ==> 56, 66

             */

            //List<int> result = Add50ToFirstThreeElements(new List<int> { 6, 16, 23, 200, 300 });
            //PrintList(result);


            /*
                Lägg till 70 till varannat element i listan

                ;
                ==> 1000, 2070, 3000, 4070, 5000

             */
            //List<int> result = Add70ToEverySecondElement(new List<int> { 1000, 2000, 3000, 4000, 5000 });
            //PrintList(result);

            /*
                Experimentera med att kombinerametoder, t.ex såhär:

                List<int> result = DivideEachNumberBy100(NegateEachNumber(new List<int> { 300, 200, -500, 1000 }));
             */


            //Console.WriteLine("RESULTAT:");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

        }

        private List<int> Add70ToEverySecondElement(List<int> list)
        {
            var addNumbers = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                    addNumbers.Add(list[i] + 70);
                else
                    addNumbers.Add(list[i]);
            }
            
            return addNumbers;
        }

        private List<int> Add50ToFirstThreeElements(List<int> list)
        {
            var addNumbers = new List<int>();

            int newNumber;

            for (int i = 0; i < list.Count; i++)
            {
                newNumber = (i < 3) ? list[i] + 50 : list[i];

                if (i < 3)
                    newNumber = list[i] + 50;
                else
                    newNumber = list[i];

                addNumbers.Add(newNumber);

            }
            return addNumbers;
        }

        private List<int> DivideEachNumberBy100(List<int> list)
        {
            var addNumbers = new List<int>();
           
            foreach (var item in list)
            {
                int newNumber = item / 100;
                addNumbers.Add(newNumber);
            }
            return addNumbers;
        }

        private List<int> GetNumbersDividableByFive(List<int> list)
        {
            var addNumbers = new List<int>();
            
          
            foreach (var item in list)
            {
                bool isDividableBy5 = item % 5 == 0;
                if (isDividableBy5)
                {
                    
                    addNumbers.Add(item);
                }
            }
            return addNumbers;
        }

        private void PrintList(List<int> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
        }

        private List<int> GetNumbersHigherThan1000(List<int> list)
        {
            var addNumbers = new List<int>();
            int newNumber;
            foreach (var item in list)
            {
                if (item > 1000)
                {
                    newNumber = item;
                    addNumbers.Add(newNumber);
                }
            }
            return addNumbers;
        }

        private List<int> Add100ToEachNumber(List<int> list)
        {
            var addNumbers = new List<int>();
            int newNumber;
            foreach (int item in list)
            {
                newNumber = 100 + item;
                addNumbers.Add(newNumber);

            }
            return addNumbers;
        }
    }
}