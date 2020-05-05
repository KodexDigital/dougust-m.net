using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TemoGasLtd.Models;

namespace TemoGasLtd.Controllers
{
    public class HomeController_1 : Controller
    {
        private readonly ILogger<HomeController_1> _logger;
        //public override List<string> GetJsFiles()
        //{
        //    return new List<string> { "Temodoug.js" };
        //}

        public HomeController_1(ILogger<HomeController_1> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            ViewData["CompanyName"] = "TemoGasLtd";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About us";
            return View();
        }
        public IActionResult Contact()
        {

            
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
