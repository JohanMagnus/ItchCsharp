using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Today: {0}", DateTime.Today);
            //Console.WriteLine("\n");

            //DateTime now = DateTime.Now;
            //Console.WriteLine(now);

            //var GermanTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Berlin Standard Time");
            //Console.WriteLine(GermanTimeZone);
            TimeZone time2 = TimeZone.CurrentTimeZone;
            DateTime test = time2.ToUniversalTime(DateTime.Now);
            var country = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
            var countrytime = TimeZoneInfo.ConvertTimeFromUtc(test, country);

            Console.WriteLine(countrytime); 
        }
    }
}
