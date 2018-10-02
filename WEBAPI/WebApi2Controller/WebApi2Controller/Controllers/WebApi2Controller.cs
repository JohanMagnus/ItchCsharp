using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2Controller.Controllers
{
    [Route("WebApi2")]
    public class WebApi2Controller : Controller
    {
        [HttpGet("Hello")]
        public string Hello()
        {
            return "Hello";
        }

        [HttpGet("HelloWorld")]
        public IActionResult HelloWorld()
        {
            return Ok("Hello World");
        }

        [HttpGet("Weekday")]
        public IActionResult Weekday()
        {
            return Ok($"Idag är det {DateTime.Today.DayOfWeek}");
           // ToString("dddd", new CultureInfo("sv-Sv"))
        }

        [HttpGet("Random")]
        public int Random()
        {
            Random rnd = new Random();
            int month = rnd.Next(1, 5);
            return month;
        }
       

    }
}
