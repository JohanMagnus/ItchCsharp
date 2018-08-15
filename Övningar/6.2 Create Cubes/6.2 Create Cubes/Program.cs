using System;

namespace _6._2_Create_Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube mycube = new Cube(2, 3, 4);
            Cube supercube = new Cube(100, 200, 300);

            mycube.WriteVolume();
            supercube.WriteVolume();

            int  volume = mycube.CalculateVolume();
            int volume2 = supercube.CalculateVolume();

            Console.WriteLine("Volume is: " + volume);
            Console.WriteLine("Volume is: " + volume2);




        }

        class Cube
        {
            int height;
            int width;
            int depth;

            public Cube(int a, int b, int c)
            {
                height = a;
                width = b;
                depth = c;
               
                
            }

            public void WriteVolume()
            {

                int volume = height * width * depth;

                Console.WriteLine("The volume of the cube is " + volume);
            }

            public int CalculateVolume()
            {
                int volume = height * width * depth;
                return volume;
               
            }

        }
    }
}
