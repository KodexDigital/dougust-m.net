using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemoGasLtd.StaticClass;

namespace TemoGasLtd.Controllers
{
	public class HomeController : Controller
	{
		[Route("welcome")]
		public IActionResult Index()
		{
			return View();
		}

		[Route("about-us")]
		public IActionResult AboutUs()
		{
			return View();
		}
		
		[Route("contact-us")]
		public IActionResult ContactUs()
		{
			return View();
		}
		[Route("photo-album")]
		public IActionResult Gallery()
		{
			return View();
		}
		[Route("esteem-clients")]
		public IActionResult Clients()
		{
			return View();
		}
		[Route("projects-so-far")]
		public IActionResult Projects1()
		{
			return View();
		}

		public IActionResult Projects()
		{
			return View();
		}
	}
}
