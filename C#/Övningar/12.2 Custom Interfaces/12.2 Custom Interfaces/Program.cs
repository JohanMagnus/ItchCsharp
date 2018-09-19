using System;
using System.IO;
using System.Collections.Generic;

namespace _12._2_Custom_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog buddy = new Dog("Buddy");
            Cat musse = new Cat("Musse");


            
            
            DoNiceThings(buddy);
            DoMeanThings(buddy);
        
            DoNiceThings(musse);
        }

        //private static void DoMeanThings(Dog buddy)
        //{
            
            
        //}

        //private static void DoNiceThings(IEnumerable<object> thing)
        //{
        //    if (object == Dog)
        //    {
        //        Console.WriteLine($" The dog {buddy.Name} says woof");
        //    }
        //    if (object == Cat)
        //    {
        //        Console.WriteLine($" The cat {);
        //    }
        //}

        //public interface IFriendly
        //{
        //    void Greet();
        //    void ThanksForDinner();
        //}

        //public interface IAggressive
        //{
        //    int Bite();
        //    void ShowTeeth();
        //}
        //public class Dog : IFriendly, IAggressive
        //{
        //    public string Name { get; set; }

        //}

        //public class Cat : IFriendly
        //{
        //    public string  Name { get; set; }
        //}
    }

   
}
