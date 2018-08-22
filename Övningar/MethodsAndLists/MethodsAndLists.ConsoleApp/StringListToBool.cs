using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class StringListToBool
    {
        public void Run()
        {
            // Demo: Returerna "true" om längen på alla ord tillsammans är större än 10

            /*
                Returnera "true" om alla ord har fem eller fler tecken
             
                bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "friday", "ooooooooo" });
                ==> true

                bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "fri", "ooooooooo" });
                ==> false
            */
            bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "frifefgdfbgdfg", "ooooooooo" });

            Console.WriteLine(result);
        }

        private bool AllWordsAreFiveLettersOrLonger(List<string> list)
        {
            var finalList = new List<string>();
            foreach (var item in list)
            {
                if (item.Length > 5)
                    finalList.Add(item);
            }
            if (finalList.Count == list.Count)
                return true;
            else
                return false;
        }
    }
}
