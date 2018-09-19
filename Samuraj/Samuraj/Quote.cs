using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuraj
{
    public class Quote
    {
        public int Id { get; set; }
        public string QuoteText { get; set; }
        public QuoteStyle StyleOfQoute { get; set; }
        public Samurai Samurai { get; set; }

    }


}
