using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("WebApi1")]
    public class WebApi1Controller : Controller
    {

        [Route("AddPlanet")]
        public IActionResult AddPlanet()
        {
            //return "Ny planet Saturnus skapad med storleken 123";
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                formContent = reader.ReadToEndAsync().Result;
            }

            string[] lista = formContent.Split('&');
            string[] lista2 = lista[0].Split('=');
            var planetName = lista2[1];
            string[] lista3 = lista[1].Split('=');
            var planetSiza = lista3[1];

            var planet = new Planet();
            planet.Name= planetName;
            planet.Size = int.Parse(planetSiza);
            return Ok($"Ny planet {planet.Name} skapad med storleken {planet.Size}");

        }

        [Route("SearchPlanet")]
        public IActionResult SearchPlanet()
        {
            //return "Ny planet Saturnus skapad med storleken 123";

            var input = Request.QueryString.ToString();
            string[] lista = input.Split('&');
            string[] lista2 = lista[0].Split('=');
            var planetName = lista2[1];
            string[] lista3 = lista[1].Split('=');
            var planetSiza = lista3[1];

            var planet = new Planet();
            planet.Name = planetName;
            planet.Size = int.Parse(planetSiza);

            return Ok($"Söker i databasen efter planeter med namn {planet.Name} och storlek {planet.Size}");

           


        }


    }
}
