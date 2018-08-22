using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToStringList
    {

        public void Run()
        {
            /*
                Lägg till tre stjärnor innan och efter siffran
                
                List<string> result = AddStars(new List<int> { 1003, 20, -130, 2040 });

                ==>  ***1003***, ***20***, ***-130***, ***2040***
            */
            // List<string> result = AddStars(new List<int> { 1003, 20, -130, 2040 });

            /*
                Samma men lägg bara till stjärnor runt de som är större än 1000
             
               

                ==>   ***1003***, 20, -130, ***2040***
            */
            //List<string> result = AddStarsToNumbersHigherThan1000(new List<int> { 1003, 20, -130, 2040 });

            /*
                Negativa tal => "ZIP"
                Positiva tal => "ZAP"
                Noll         => "BOING"
            
                List<string> result = NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(new List<int> { 1003, 20, -130, 0, 2040 });
 
                =>    ZAP, ZAP, ZIP, BOING, ZAP
            */
            List<string> result1 = NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(new List<int> { 1003, 20, -130, 0, 2040 });

            /*
              
                Skapa en lista av strängar som meddelar om personen är kort eller lång (över 160cm). Hoppa över orimliga värden

                List<string> result = LongOrShort(new List<int> {170, 130, 205, -10, 600, 180});

                ==>    LÅNG, KORT, LÅNG, LÅNG

             */
            List<string> result = LongOrShort(new List<int> { 170, 130, 205, -10, 600, 180 });

            foreach (var item in result)
            {
                Console.WriteLine(item.PadLeft(20));
            }
        }

        private List<string> LongOrShort(List<int> list)
        {
            var finalList = new List<string>();
            foreach (var item in list)
            {
                if (item > 225 || 0 > item)
                    continue;
                else if (item > 150)
                    finalList.Add("LÅNG");
                else
                    finalList.Add("KORT");
                        



            }
            return finalList;
        }

        private List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> list)
        {
            var finalList = new List<string>();
            foreach (int item in list)
            {
                if (item > 0)
                {
                    string newElement = "ZAP";
                    finalList.Add(newElement);
                }
                else if (item == 0)
                {
                    string Foo = "BOING";
                    finalList.Add(Foo);
                }
                else
                {
                    string Boo = "ZIP";
                    finalList.Add(Boo);
                }

            }
            return finalList;
        }

        private List<string> AddStarsToNumbersHigherThan1000(List<int> list)
        {
            var finalList = new List<string>();
            foreach (int item in list)
            {
                if (item > 1000)
                {
                    string newElement = $"***{item}***";
                    finalList.Add(newElement);
                }
                else
                {
                    string Boo = $"{item}";
                    finalList.Add(Boo);
                }
            }
            return finalList;
        }

        private List<string> AddStars(List<int> list)
        {
            var finalList = new List<string>();
            foreach (int item in list)
            {
                string newElement = $"***{item}***";
                finalList.Add(newElement);
            }
            return finalList;
        }
    }
}