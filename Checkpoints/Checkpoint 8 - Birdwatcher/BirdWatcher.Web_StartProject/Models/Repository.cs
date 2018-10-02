using System;
using System.Collections.Generic;
using System.Linq;

namespace BirdWatcher.Web.Models
{
    public class Repository
    {
        private readonly ObservationContext _context;

        public Repository(ObservationContext context)
        {
            _context = context;
        }

        public void Add(Observation observation)
        {
            _context.Add(observation);
            _context.SaveChanges();
        }

        public void RecreateDatabase()
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
        }

        internal List<Observation> GetAll()
        {

            Random rnd = new Random();
            int counter = rnd.Next(0, 3);
           
                if (counter == 1)
                {
                    var list = _context.Observations.OrderBy(a => a.Specie).ToList();
                    return list;
                }
                if (counter ==2)
                {
                    var list = _context.Observations.OrderByDescending(a => a.Time).ToList();
                    return list;
                }
            var list2 = _context.Observations.OrderBy(a => a.Location).ToList();
            return list2;

        }
        internal List<string> GetAllSpecies()
        {

            var list = _context.Observations.Select(a => a.Specie).OrderBy(a => a).Distinct().ToList();
            return list;
           

        }
    }
}
