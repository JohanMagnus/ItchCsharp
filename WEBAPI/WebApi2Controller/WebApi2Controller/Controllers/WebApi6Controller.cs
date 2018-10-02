using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2Controller.Controllers
{
    [Route("WebApi6")]
    public class WebApi6Controller : Controller
    {
        [Route ("AddDocument")]
        public IActionResult AddDocument(Document document)
        {

            return Ok(document);
        }
    }
}
