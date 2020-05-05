using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TemoGasLtd.Controllers
{
    public class OperationBaseController : Controller
    {
        [Route("operation-base")]
        public IActionResult Index()
        {
            return View();
        }
    }
}