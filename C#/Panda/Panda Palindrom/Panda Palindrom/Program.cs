using System;

namespace Panda_Palindrom
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("Mata in ett ord");
            string inmatat = Console.ReadLine();

            if (Palindrom(inmatat))
            {
                Console.WriteLine("Palindrom!");
            }
            else
                Console.WriteLine("Inte palindrom :( ");
        }

        private static bool Palindrom(string inmatat)
        {
            bool isPalindrom = false;
            for (int i = 0; i <= (inmatat.Length - 1) / 2; i++)
            {
                isPalindrom = (inmatat[i] == inmatat[inmatat.Length - 1 - i]);

                if (!isPalindrom)
                    break;

            }
            return isPalindrom;
        }

    }
}
