using System;
using System.Linq;

namespace Samuraj
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //FindSamuraiWithRealName(name);
            //ClearDatabase();
            ListAllSamuraiNames();

            //AddOneSamurai();
            //AddSomeSamurais("Kalle");
            //AddSomeSamurais("Oscar");
            //AddSomeSamurais("Chris");
            //AddSomeSamurais("Tom");
            //AddSomeSamurais("Boris");

            //AddSomeBattles();

            //AddOneSamuraiWithRelatedData();

        }

        private static void FindSamuraiWithRealName(string v)
        {
            var context = new SamuraiContext();

            Samurai samurai = context.Samurais.Where(x => x.SecretIdentity.RealName == v).SingleOrDefault();
            if (samurai == null)
            {
                Console.WriteLine("There is no such samurai.");
            }
            else
                Console.WriteLine(samurai.Name);



        }

        private static void ListAllSamuraiNames()
        {
            var context = new SamuraiContext();
            //int counter = 0;
            //foreach (var samurai in context.Samurais.OrderBy(x=>x.Name))
            //{
            //    counter++;
            //    Console.WriteLine($"{counter}   {samurai.Name}  ");
            //}
            foreach (var samurai in context.Samurais.OrderByDescending(x => x.Id))
            {
                
                Console.WriteLine($"{samurai.Id} {samurai.Name}  ");
            }
        }

        private static void ClearDatabase()
        {
            var context = new SamuraiContext();

            foreach (var samurai in context.Samurais)
            {
                context.Remove(samurai);
            }
            foreach (var battle in context.Battles)
            {
                context.Remove(battle);
            }
            foreach (var quote in context.Quotes )
            {
                context.Remove(quote);
            }
            foreach (var item in context.SecretIdentities)
            {
                context.Remove(item);
            }
            foreach (var item in context.SamuraiBattles)
            {
                context.Remove(item);
            }
            foreach (var item in context.BattleLogs)
            {
                context.Remove(item);
            }
            foreach (var item in context.BattleEvents)
            {
                context.Remove(item);
            }
        }

        private static void AddOneSamuraiWithRelatedData()
        {
            
        }

        private static void AddSomeBattles()
        {
            var b = new Battle()
            {
                StartDate = DateTime.FromOADate(2017),
                EndDate = DateTime.Now.AddDays(40),
                BattleLog = new BattleLog()
                {
                    Name = "Slaget om slaget",
                    
                },
                Brutal = true
            };


            using (var context = new SamuraiContext())
            {
                context.Add(b);
                context.SaveChanges();
            }

        }

        private static void AddSomeSamurais(string v)
        {
            var samurai = new Samurai
            { Name = v,
              SecretIdentity = new SecretIdentity
              {
                  RealName = "Tom Cruise",
                 
              }

            };

            using (var context = new SamuraiContext())
            {
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }

        private static void AddOneSamurai()
        {
            var samurai = new Samurai
            { Name = "Zelda", Haircut = HairCut.Western };

            using (var context = new SamuraiContext())
            {
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }

        }
    }
}
