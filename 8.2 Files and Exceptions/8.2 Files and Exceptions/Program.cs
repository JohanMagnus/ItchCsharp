using System;
using System.IO;

namespace _8._2_Files_and_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                while(true)
            try
            {
                Console.Write("Enter a file name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                var input = Console.ReadLine();
                File.CreateText(input);
                Console.WriteLine($"Du skrev in  {input}");

                    break;


            }
            catch (FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Denna fil finns inte");
            }
            catch (DirectoryNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Directory not found");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Kunde ej skapa fil");
            }
            
            


        }
    }
}
