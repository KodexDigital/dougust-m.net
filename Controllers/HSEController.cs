using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TemoGasLtd.Controllers
{
    public class HSEController : Controller
    {
        [Route("hse")]
        public IActionResult Index()
        {
            return View();
        }
    }
}