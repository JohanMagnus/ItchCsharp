using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApi2Controller.Controllers
{
    [Route("WebApi3")]
    public class WebApi3Controller : Controller
    {
        [HttpGet("Frukost")]
        public IActionResult Frukost(string frukost)
        {
            frukost.ToLower();
            if (frukost == "ägg")
                return Ok($"{frukost} är ju inte gott");
            else
                return Ok($"Ja, {frukost.ToLower()} är ju gott");
        }
        [HttpGet("Kvadrat")]
        public IActionResult Kvadrat(int kvadrat)
        {
            int sum = kvadrat * kvadrat;
            return Ok(sum);

        }
        [HttpGet("Lista")]
        public IActionResult Lista(int fran, int till)
        {

            List<int> numberArray = new List<int>();

            for (int i = fran; i < till; i++)
            {
                numberArray.Add(i);
            }

            return Ok(numberArray);

        }
        [HttpGet("Chocolate")]
        public IActionResult Chocolate(int? chocolate)
        {

            if (chocolate == 0)
                return BadRequest("0 går ej att dela med");
            if (chocolate == null)
                return BadRequest("Inte ok");

            if (chocolate > 25)
                return BadRequest("Det får max delas på 25 personer");
            else 
            {
                decimal split = 25 / (int)chocolate;

                return Ok($"Varje person får {split} st bitar");
            }
        }

        [HttpGet("Order")]
        public IActionResult Order(string orderNumber)
        {
            //    // [A-Z]{2}-[0-9]{4}
            //    Regex rx = new Regex(@"\w{2}-\d{4}");
            //    if (rx.IsMatch(orderNumber))
            //    {
            //        Regex rgx = new Regex(@"\w{2}-[0-2]\d{4})");
            //        if (rgx.IsMatch(orderNumber))
            //        {
            //            return Ok($"{orderNumber} finns i systemet");
            //        }
            //        else return NotFound($"{orderNumber} finns inte i systemet");
            //    }
            //    else return BadRequest("Fel format");
            //

            
            Regex rx = new Regex(@"[A-Z a-z]{2}-[0-9]{4}$");
            if (rx.IsMatch(orderNumber))
            {
                Regex rgx= new Regex(@"[A-Z a-z]{2}-[0-2]{1}[0-9]{3}$");
                if (rgx.IsMatch(orderNumber))
                    return Ok($"{orderNumber} finns i systemet");
                else
                   return NotFound($"{orderNumber} finns INTE i systemet");

            }
            else
                return BadRequest("Fel format");
        }
        [HttpGet("FamilyGuy")]
        public IActionResult FamilyGuy(string inputname)
        {
            if (inputname == "Stewie")
                return BadRequest("DATA ERROR");
            if (inputname == "Brian" || inputname == "Lois" || inputname == "Meg")
                return Content($"<img src= '/thumbsup.jpg' />", "text/html");
            else
                return Ok("Hej");
            //"<img src='croplight.jpg' />"

        }
        [HttpGet("AddPerson")]
        public IActionResult AddPerson(SimplePerson person)
        {
                return Ok($"Bra gjort! {person.Name} är {person.Age} och lades till i databasen");
        }
        [HttpGet("AddPersonValidate")]
        public IActionResult AddPersonValidate(SimplePerson person)
        {
            if (person.Name == null || person?.Age == null)
                return BadRequest("Förnamn och ålder måste anges");
            if (person.Age < 1|| person.Age > 119)
                return BadRequest("Nu har du varit orimlig, så gammal eller ung kan du inte vara");
            if (person.Name.Length > 20)
                return BadRequest("Så långt namn kan du inte ha");

            return Ok($"Bra gjort! {person.Name} är {person.Age} och lades till i databasen");
        }
        [HttpGet("AddPersonValidateAttribute")]
        public IActionResult AddPersonValidateAttribute(SimplePerson person)
        {
            if (ModelState.IsValid)
                return Ok($"Bra gjort! {person.Name} är {person.Age} och lades till i databasen");
            else
                return BadRequest(ModelState);
            
        }
    }
    
}
