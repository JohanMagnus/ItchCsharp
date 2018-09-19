using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuraj
{
    public class DataAccess
    {
        private readonly SamuraiContext _context;

        public DataAccess()
        {
            _context = new SamuraiContext();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }




    }
}
