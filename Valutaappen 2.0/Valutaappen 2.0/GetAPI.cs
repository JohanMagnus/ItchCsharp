using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valutaappen_2._0
{
    public class Currency
    {
        public string Code { get; set; }
        public decimal Rate { get; set; }
    }

    public class GetAPI
    {
        public bool Success { get; set; }
        public int TimeStamp { get; set; }
        public string Base { get; set; }
        public DateTime Date { get; set; }
        public object Rates { get; set; }

        //public List<Currency> Currencies { get; set; }
    }
  //    "success":true,
  //"timestamp":1536133447,
  //"base":"EUR",
  //"date":"2018-09-05",
  //"rates":{
  //  "AED":4.244594,
}
