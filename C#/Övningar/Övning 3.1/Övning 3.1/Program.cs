using System;

namespace Övning_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("When did you go to bed yesterday?");
            int bedTime = int.Parse(Console.ReadLine();

          

            Console.Write("When did you wake up?");
            string wakeUpTime = Console.ReadLine();
            int wakeUp = int.Parse(wakeUpTime);



            DateTime t1 = Convert.ToDateTime(bedTimeHour);
            DateTime t2 = Convert.ToDateTime(wakeUp);
            TimeSpan ts = t1.Subtract(t2);
            Console.WriteLine(ts);






        }
    }
}
