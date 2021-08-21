using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("myhome")]
    public class HomeController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
