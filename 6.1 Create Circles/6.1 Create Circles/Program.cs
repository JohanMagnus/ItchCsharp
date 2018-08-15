using System;

namespace _6._1_Create_Circles
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle Bob = new Circle("Bob",8);
            Circle Lisa = new Circle("Lisa", 30);
            Circle Ali = new Circle("Ali", 5);


            Bob.SayHello();
            Lisa.SayHello();
            Ali.SayHello();

            Console.WriteLine();

            Bob.WriteArea();
            Lisa.WriteArea();
            Ali.WriteArea();
        }
    }

    class Circle
    {
        int radius;
        string name;

        public Circle(string a, int b)
        {
            name = a;
            radius = b;

        }
        

        public void SayHello()
        {
            Console.WriteLine(name); 
        }



        public void WriteArea()
        {
            Console.WriteLine(radius*radius*3.14);
        }

    }
}
