using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuraj
{
    public class BattleLog
    {
        public int Id { get; set; }
        public int BattleId { get; set; }
        public string  Name { get; set; }
        public List<BattleEvent> ListOfEvents{ get; set; }
        public Battle Battle { get; set; }

    }
}
