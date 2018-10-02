using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2Controller
{
    public class SimplePerson
    {
        [StringLength(10, MinimumLength =2)]
        [Required]
        public string Name { get; set; }
        [Range(1,120)]
        [Required]
        public int Age { get; set; }
    }
}
