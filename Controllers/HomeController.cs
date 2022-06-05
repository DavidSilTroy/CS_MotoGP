using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MotoGP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Controllers
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
        public IActionResult Menu()
        {
            var MGpRandomNumber = new Random();
            ViewData["BannerNr"] = MGpRandomNumber.Next(1, 5);
            return View();
        }

        public IActionResult ListRaces()
        {
            return View();
        }
        public IActionResult ListRiders()
        {
            return View();
        }
        public IActionResult ListTeams()
        {
            return View();
        }
        public IActionResult OrderTickets()
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
