using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class StringListToNumber
    {
        public void Run()
        {
            /*
                Hissen börjar på våning 0. 
                För varje "UPP" åker den upp en våning
                För varje "NER" åker den ner en våning

                            
                ==> 2
             */
            int result = ElevatorGoUpAndDown(new List<string> { "UPP", "NER", "UPP", "UPP", "UPP", "upp", "ner" });
            Console.WriteLine(result);
        }

        private int ElevatorGoUpAndDown(List<string> list)
        {

            int counter = 0;
            foreach (string item in list)
            {
                string tecken = item.ToUpper();
                if (tecken == "UPP")
                    counter++;
                else if (tecken == "NER")
                    counter--;
            }
            return counter;
        }
    }
}
