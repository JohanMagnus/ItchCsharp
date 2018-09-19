using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skenfrukter
{
    public class Basket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FruitsInBasket FruitsInBasket { get; set; }
    }
}
