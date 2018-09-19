using System;
using System.IO;


namespace _9._2_Watch_a_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new FileSystemWatcher();

            watch.Path = @"c:\TMP";
            watch.EnableRaisingEvents = true;
            watch.Created += AddFile;
            watch.Changed += FileChanged;
            watch.Deleted += FileDeleted;
            watch.Renamed += Renamed;
            Console.WriteLine("Im watching this folder: " + watch.Path);

            Console.ReadKey();
        }

        private static void Renamed(object sender, RenamedEventArgs watch)
        {
            Console.WriteLine($"Filen {watch.Name} bytte namn!");
        }

        private static void FileDeleted(object sender, FileSystemEventArgs watch)
        {
            Console.WriteLine($"Filen {watch.Name} togs bort!");
        }

        private static void FileChanged(object sender, FileSystemEventArgs watch)
        {
            Console.WriteLine("Filen " + watch.Name + " har ÄNDRATS!");
        }

        private static void AddFile(object sender, FileSystemEventArgs watch)
        {
            Console.WriteLine("Filen " + watch.Name + " har skapats!");
        }
    }
}
