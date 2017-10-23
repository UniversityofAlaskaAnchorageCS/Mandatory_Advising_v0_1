using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mandatory_Advising_v0_1.Models;

namespace Mandatory_Advising_v0_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Uaa()
        {
            return Redirect("https://www.uaa.alaska.edu/");
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Transcripts()
        {
            return View();
        }
        public IActionResult Calendar()
        {
            return View();
        }
        public IActionResult Goal()
        {
            return View();
        }
        public IActionResult Comments()
        {
            return View();
        }
    }
}
