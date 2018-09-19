using System;

namespace _4._1_Creating_methods
{
    class Program
    {
        static void Main(string[] args)
        {
           string MainStrang =  GetInputFromUser();
            string[] array = CreateArrayOfPeople(MainStrang);
            PrintList(array);

            

        }

        static string GetInputFromUser()
        {
            Console.Write("Enter names separated by comma: ");
            string name = Console.ReadLine();

            return name;

            
           
        }
        static string[] CreateArrayOfPeople(string name)
        {
            string[] nameList = name.ToUpper().Split(", ");
            return nameList;
        }

        
        

        static void  PrintList(Array peopleArray)
        {


            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var item in peopleArray)
            {
                Console.WriteLine("***SUPER-" + item + "***");
            }

          

        }

        

    }


}
