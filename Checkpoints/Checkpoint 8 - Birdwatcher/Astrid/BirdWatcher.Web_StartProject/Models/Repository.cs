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
        public IEnumerable<Observation> GetAll()
        {
            return _context.Observations.OrderBy(x => x.Date);
        }

        public IEnumerable<Observation> GetAllSpecies()
        {
            return _context.Observations.GroupBy(i => i.Specie).Select(group => group.First()).OrderBy(x => x.Specie);
        }
    }
}
