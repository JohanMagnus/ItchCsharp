using System;
using System.Collections.Generic;
using BirdWatcher.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BirdWatcher.Web.Controllers
{
    [Route("observation")]
    public class ObservationController : Controller
    {
        private readonly Repository _repo;

        public ObservationController(Repository repo)
        {
            _repo = repo;
        }

        [HttpPost("recreate")]
        public IActionResult RecreateDatabase()
        {
            _repo.RecreateDatabase();
            return Ok();
        }

        [HttpPost("AddObservation")]
        public IActionResult Add([FromBody]Observation observation)
        {
            _repo.Add(observation);
            return Ok($"{observation.Specie} lades till i databasen");

        }

        [HttpGet("show")]
        public IActionResult GetAll()
        {
            List<Observation> all = _repo.GetAll();

            return Ok(all);
        }

        [HttpGet("showSpecies")]
        public IActionResult GetAllSpecies()
        {
            var all = _repo.GetAllSpecies();
        
            return Ok(all);
        }

    }
}
