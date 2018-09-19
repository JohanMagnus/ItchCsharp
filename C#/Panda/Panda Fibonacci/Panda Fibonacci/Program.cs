using System;

namespace Panda_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] fibonacci = new int[100];
            var a = 0;
            var b = 1;
            var c = 0;
            
            for (int i = 0; i < fibonacci.Length; i++)
            {

                fibonacci[i] = a + b;
                c = a;
                a = b;
                b = c+ b;

            }

            PrintList(fibonacci);

            //int[] fibo = { 1, 1, 2, 3, 5, 8, 13 };

        }

        private static void PrintList(int[] fibonacci)
        {
            foreach (var item in fibonacci)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
