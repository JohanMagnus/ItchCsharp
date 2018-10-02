using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2Controller
{
    public class Document
    {
        public string Title { get; set; }
        public int NumberOfPages { get; set; }
        public bool HasSummary { get; set; }
        public DateTime PublishedFrom { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public string Tags { get; set; }
        public int Rating { get; set; }

    }
}
