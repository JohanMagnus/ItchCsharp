using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skenfrukter
{
    public class DataAccess : IDisposable
    {

        private readonly FruitContext _context;

        public DataAccess()
        {
            _context = new FruitContext();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        internal void ClearDatabase()
        {
            foreach (var fruit in _context.Fruits)
            {
                _context.Remove(fruit);
            }
            foreach (var fruit in _context.FruitCategories)
            {
                _context.Remove(fruit);
            }


        }

        internal void AddCategoriesAndFruits()
        {
            var Skenfrukter = new FruitCategory
            {
                Name = "Skenfrukt"
            };
            
            var KallaFrukter = new FruitCategory
            {
                Name = "Kalla Frukter"
            };
            var MjukaFrukter = new FruitCategory
            {
                Name = "Mjuka Frukter"
            };

            _context.FruitCategories.Add(Skenfrukter);
            _context.FruitCategories.Add(KallaFrukter);
            _context.FruitCategories.Add(MjukaFrukter);


            var f = new Fruit
            {
                Name = "Citron",
                Price = 12.9M,
                Category = MjukaFrukter
                

            };
            _context.Fruits.Add(f);

            _context.Add(new Fruit

            {
                Name = "Russin",
                Price = 8, 
                Category = Skenfrukter
            });


            _context.SaveChanges();
        }

        internal List<Fruit> GetFruitsInCategory(string v)
        {
            return _context.FruitCategories
                       .Include(x => x.FruitList)
                       .SingleOrDefault(x => x.Name == v)
                       ?.FruitList.ToList() ?? new List<Fruit>();
        }

        internal List<Fruit> GetAll()
        {
            return _context.Fruits.Include(x => x.Category).ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
