using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_crofth.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_crofth.Controllers
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

        [HttpGet]
        public IActionResult MovieForm ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm (Movie movie)
        {
            return View("MovieSubmitted", movie);
        }

        public IActionResult Podcasts ()
        {
            return View("MyPodcasts");
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
