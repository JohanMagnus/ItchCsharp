using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valutaappen_2._0
{
    public class GetAPI
    {
        public bool Success { get; set; }
        public int TimeStamp { get; set; }
        public string Currency { get; set; }
        public DateTime Date { get; set; }
        public string Rates { get; set; }
    }
      "success":true,
  "timestamp":1536133447,
  "base":"EUR",
  "date":"2018-09-05",
  "rates":{
    "AED":4.244594,
}
