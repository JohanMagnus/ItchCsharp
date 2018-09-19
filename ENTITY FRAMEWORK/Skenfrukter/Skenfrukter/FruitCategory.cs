using System.Collections.Generic;

namespace Skenfrukter
{
    public class FruitCategory
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public List<Fruit> FruitList { get; set; }
    }
}