using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skenfrukter
{
    public class Fruit
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public decimal Price { get; set; }
        public FruitCategory Category { get; set; }


    }
}
