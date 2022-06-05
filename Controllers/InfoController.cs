using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotoGP.Data;
using MotoGP.Models;
using MotoGP.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MotoGp.Controllers
{
    public class InfoController : Controller
    {
        private readonly GPContext _context;

        public InfoController(GPContext context)
        {
            _context = context;
        }
        // GET: InfoController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult ListRaces()
        {
            ViewData["Title"] = "Races";
            ViewData["BannerNr"] = 0;

            
            var races = _context.Races;

            List<int> monthFromRaces =
                races
                    .GroupBy(r => r.Date.Month)
                    .Select(i => i.Key
                    ).ToList();

            var racesPerMonthList = new List<ListRacesViewModel>();
                
            foreach (var month in monthFromRaces)
            {
                racesPerMonthList.Add(
                    new ListRacesViewModel()
                    {
                        MonthName = (new DateTime(2022, month, 1)).ToString("MMMM"),
                        Races = races.Where(r => r.Date.Month == month).OrderBy(r => r.Date).ToList()
                    }
                );
            }

            return View(racesPerMonthList);
        }
        public IActionResult ListRiders()
        {
            ViewData["Title"] = "Riders";
            ViewData["BannerNr"] = 1;
            return View();
        }
        public IActionResult ListTeams()
        {
            ViewData["Title"] = "Teams";
            ViewData["BannerNr"] = 2;
            return View();
        }
        public IActionResult BuildMap()
        {
            ViewData["Title"] = "Map";
            ViewData["BannerNr"] = 0;
            var races = _context.Races;
            return View(races.ToList());
        }
        public IActionResult ShowRace(int id = 0)
        {
            
            ViewData["BannerNr"] = 0;

            if (id == 0) 
            { 
                return BuildMap(); 
            }

            var race = _context.Races.Where(r => r.RaceID == id);
            ViewData["Title"] = "Race - " + race.FirstOrDefault().Name;
            return View(race.ToList()); 
        }

        

        // GET: InfoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InfoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InfoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InfoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InfoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InfoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InfoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
