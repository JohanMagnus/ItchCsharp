using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot.Controllers
{
    public class SquareRootContollers : Controller
    {
        [HttpGet("api/squareroot")]
        public IActionResult SquareRoot(int? number, int decimals)
        {
            if (number == null)
                return BadRequest("Felaktig inmatning, ange ett tal");           
            if (number < 0)
                return BadRequest("Negativa tal är inte OK");
            

            var result = Math.Sqrt((int)number);

            return Ok(Math.Round(result, decimals));

          

            
        }
    }
}
