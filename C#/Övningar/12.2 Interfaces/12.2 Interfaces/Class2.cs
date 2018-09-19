using System;
using System.Collections.Generic;
using System.Text;
using static _12._2_Interfaces.Program;

namespace _12._2_Interfaces
{
    public class Cat : IFriendly
    {
        public string  Name { get; set; }
    }

    public class Dog : IAgressive, IFriendly
    {
        public string Name { get; set; }

        public int Bite()
        {
            Console.WriteLine(($"The dog {Name} shows his teeth");
        }
        public void Greet()
        {
            Console.WriteLine(($"The dog {Name} says woof");
        }
        public void ThanksForDinner(string meal)
        {
            Console.WriteLine(($"The dog {Name} thank you for the {meal}");
        }
    }
}
