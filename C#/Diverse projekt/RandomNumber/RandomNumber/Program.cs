using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett nummer: ");
            int number = int.Parse(Console.ReadLine());



            int sum = 0;
            for (int i = 0; i < number + 1; i++)
            {

              
                sum = sum + i;
                
                
            }
            Console.WriteLine("Summan av alla nummer till ditt nummer är: " + sum);

        }
    }
}
