using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace Reseapp
{
    
    class Program
    {
        static void Main(string[] args)
        {

            using (SoundPlayer player = new SoundPlayer("marley.wav"))
            {
                // Use PlaySync to load and then play the sound.
                // ... The program will pause until the sound is complete.
                player.Play();

            }
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ResetColor();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
   
            bool meny = true;
            while (meny)
            {

                //Console.BackgroundColor = ConsoleColor.Gray;
               // Console.Clear();
                Console.WriteLine();

                RotatingColors("★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                //Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine(" Välkommen till valuta- och tidsappen! Vi begränsar dig till dessa 7 länder:");
                Console.WriteLine();
                Console.WriteLine(" Tyskland    Australien    Kroatien    England    Thailand    Danmark    USA");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                RotatingColors("★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀★✈☀");
              

                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Skriv V för att kolla valuta, skriv T för att kolla tidszon.");
                //Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("[V] Valuta  $");
                Console.WriteLine("[T] Tidszon ⏰");
                Console.WriteLine("[Q]uit      ⛔");

                Console.Write("\n");

                string val = Console.ReadLine().ToUpper().Trim();
                
                
                switch (val)
                {
                    case "V":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Vilken valuta vill du konvertera?");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                        Console.WriteLine("[E] Euro");
                        Console.WriteLine("[U] US Dollar");
                        Console.WriteLine("[P] Brittiska Pund");
                        Console.WriteLine("[D] Danska Kronor");
                        Console.WriteLine("[T] Thailändska Bath");
                        Console.WriteLine("[K] Kroatiska Kuna");
                        Console.WriteLine("[A] Australiska Dollar");
                        decimal valdValuta = 0;
                        Console.WriteLine();
                        

                        while (true)
                        {
                            string valValuta = Console.ReadLine().ToUpper().Trim();
                            
                            
                            try
                            {
                                valdValuta= ValutaVal(valValuta);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Du har matat in ett felaktigt värde, mata in ett nytt");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Magenta;
                       // Console.BackgroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Ange i svenska kronor hur mycket du vill konvertera:");
                        
                       // Console.BackgroundColor = ConsoleColor.Gray;
                        //Console.Clear();
                        //Console.ResetColor();
                        decimal inmatad = decimal.Parse(Console.ReadLine());
                        var total=Math.Round(Valutauträknare(valdValuta, inmatad), 2);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;              
                        Console.WriteLine(inmatad + " svenska kronor blir "+total+ " i vald valuta. ");
                        Console.WriteLine("Tryck Enter för att kommma tillbaka till startmenyn.");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.ReadKey();
                        //Console.Clear();

                        break;

                       


                    case "T":
                        DateTime sverige = DateTime.Now;
                        var now = sverige.ToShortTimeString();

                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine($"Klockan är nu {now} i Stockholm, vilken huvudstad vill du jämföra med?");
                        Console.WriteLine("Tänk på att undvika jetlag när du reser!");
                        Console.ForegroundColor = ConsoleColor.Black;
                        //Console.ResetColor();
                        Console.WriteLine("[B] Berlin");
                        Console.WriteLine("[S] Sydney");
                        Console.WriteLine("[Z] Zagreb");
                        Console.WriteLine("[L] London");
                        Console.WriteLine("[BA] Bangkok");
                        Console.WriteLine("[K] Köpenhamn");
                        Console.WriteLine("[W] Washington");
                        Console.WriteLine();
                        DateTime valdStad;
                        while (true)
                        {
                            string valStad = Console.ReadLine().ToUpper().Trim();


                            try
                            {
                                valdStad = TidIStad(valStad);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Du har matat in ett felaktigt värde, mata in ett nytt.");
                            }
                        }

                        TimeSpan konverterad = Tidsskillnad(sverige, valdStad);
                        var trimmad = Math.Round(konverterad.TotalHours);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Tiden i staden du angett är " + valdStad.ToShortTimeString()+",och tidsskillnaden mot Stockholm är " + trimmad + " timmar.");
                        Console.WriteLine("Tryck Enter för att komma tillbaka till startmenyn.");
                        Console.ReadKey();
                        Console.Clear();

                        break;


                    case "Q":
                       
               
                        Console.WriteLine("Programmet avslutas.");
                        meny = false;

                        break;




                        default:
                            Console.WriteLine("Du har matat in ett felaktigt värde, vänligen ange V, T eller Q!");
                        break;
                }
                
            }
        }

        private static void RotatingColors(string text)
        {
            var palette = new List<ConsoleColor> { ConsoleColor.DarkGreen, ConsoleColor.Red, ConsoleColor.Yellow };

            for (int i = 0; i < text.Length; i++)
            {
                Console.ForegroundColor = palette[i % 3]; // 0 1 2 3 0 1 2 3 0 1 2 3 
                Console.Write(text[i]);
                
            }
            Console.WriteLine();
        }

        private static TimeSpan Tidsskillnad(DateTime sverige, DateTime valdStad)
        {
            var skillnad = valdStad - sverige;
            //string konverterad = Convert.ToString(skillnad);
            return skillnad;
        }

        private static DateTime TidIStad(string valStad)
        {
            switch (valStad)
            {
                case "B":
                    TimeZone time2 = TimeZone.CurrentTimeZone;
                    DateTime test = time2.ToUniversalTime(DateTime.Now);
                    var berlin = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
                    var berlintime = TimeZoneInfo.ConvertTimeFromUtc(test, berlin);

                    return berlintime;

                    case "S":
                    TimeZone time3 = TimeZone.CurrentTimeZone;
                    DateTime test1 = time3.ToUniversalTime(DateTime.Now);
                    var sydney = TimeZoneInfo.FindSystemTimeZoneById("W. Australia Standard Time");
                    var sydneytime= TimeZoneInfo.ConvertTimeFromUtc(test1, sydney);
                    return sydneytime;

                case "Z":
                    TimeZone time4 = TimeZone.CurrentTimeZone;
                    DateTime test2 = time4.ToUniversalTime(DateTime.Now);
                    var zagreb = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
                    var zagrebtime = TimeZoneInfo.ConvertTimeFromUtc(test2, zagreb);

                    return zagrebtime;

                case "L":
                    TimeZone time5 = TimeZone.CurrentTimeZone;
                    DateTime test3 = time5.ToUniversalTime(DateTime.Now);
                    var london = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
                    var londontime = TimeZoneInfo.ConvertTimeFromUtc(test3, london);

                    return londontime;

                case "BA":
                    TimeZone time6 = TimeZone.CurrentTimeZone;
                    DateTime test4 = time6.ToUniversalTime(DateTime.Now);
                    var bangkok = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
                    var bangkoktime = TimeZoneInfo.ConvertTimeFromUtc(test4, bangkok);

                    return bangkoktime;

                case "K":
                    TimeZone time7 = TimeZone.CurrentTimeZone;
                    DateTime test5 = time7.ToUniversalTime(DateTime.Now);
                    var köpenhamn = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
                    var köpenhamntime = TimeZoneInfo.ConvertTimeFromUtc(test5, köpenhamn);

                    return köpenhamntime;

                case "W":
                    TimeZone time8  = TimeZone.CurrentTimeZone;
                    DateTime test6 = time8.ToUniversalTime(DateTime.Now);
                    var washington = TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time");
                    var washingtontime = TimeZoneInfo.ConvertTimeFromUtc(test6, washington);

                    return washingtontime;

            }
            throw new Exception();
        }

        private static decimal Valutauträknare(decimal valdValuta, decimal inmatad)
        {
            var summa = inmatad / valdValuta ;
            return summa;
        }



        private static decimal ValutaVal(string valValuta)
        {

            switch (valValuta)
            {
                case "E":   
                    return 11.17M;

                case "U":
                    return 9.74M;

                case "P":
                    return 12.45M;

                case "D":
                    return 1.48M;

                case "T":
                    return 0.31M;

                case "K":
                    return 1.53M;

                case "A":
                    return 7.15M;
            }
            throw new Exception(); 
        }

        
        
            
        
    }
}

