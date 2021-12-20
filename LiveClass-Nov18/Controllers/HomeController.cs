using LiveClass_Nov18.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LiveClass_Nov18.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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

        [HttpPost]
        public IActionResult ViewDataSubmit(string name, string address, string course, string year)
        {
            ViewData["name"] = name;
            ViewData["address"] = address;
            ViewData["course"] = course;
            ViewData["year"] = year;

            return View();
        }
        [HttpPost]
        public IActionResult ViewBagSubmit(string name, string address, string course, string year)
        {
            ViewBag.name = name;
            ViewBag.address = address;
            ViewBag.course = course;
            ViewBag.year = year;

            return View();
        }

        [HttpPost]
        public IActionResult TempDataRedirect(string name, string address, string course, string year)
        {
            TempData["name"] = name;
            TempData["address"] = address;
            TempData["course"] = course;
            TempData["year"] = year;

            return RedirectToAction("TempDataSubmit");
        }

        public IActionResult TempDataSubmit()
        {
            return View();
        }
    }
}
