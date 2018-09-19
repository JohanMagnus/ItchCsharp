using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuraj
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public HairCut Haircut { get; set; }
        public SecretIdentity SecretIdentity { get; set; }

        public List<SamuraiBattle> SamuraiBattle { get; set; }
    }
}
