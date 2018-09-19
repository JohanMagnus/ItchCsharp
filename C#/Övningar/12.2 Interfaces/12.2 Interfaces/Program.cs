using System;

namespace _12._2_Interfaces
{
    /// <summary>
    /// Här försöker vi att skapa ett program med INterfaces. 
    /// </summary>
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

        public static void DoMeanThings(Dog buddy)
        {
            throw new NotImplementedException();
        }

        public static void DoNiceThings(Dog buddy)
        {
            throw new NotImplementedException();
        }
        public interface IFriendly
        {
            void Greet();
            void ThanksForDinner(string meal);
        }
        public interface IAgressive
        {
            int Bite();
            void ShowTeeth();
        }
    }
}
