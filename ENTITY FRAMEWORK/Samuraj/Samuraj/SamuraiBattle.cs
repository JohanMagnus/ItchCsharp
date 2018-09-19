using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuraj
{
    public class SamuraiBattle
    {
        
        public int BattleId { get; set; }
        public int SamuraiId { get; set; }

        public Samurai Samurai { get; set; }
        public Battle Battle { get; set; }
    }
}
