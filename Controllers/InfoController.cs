using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotoGP.Models;
using System.Collections.Generic;

namespace MotoGp.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult ListRaces()
        {
            ViewData["Title"] = "Races";
            ViewData["BannerNr"] = 0;
            return View();
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
            //List<Race> races = new List<Race>();
            //races.Add( new Race() { RaceID = 1, X = 517, Y = 19, Name = "Assen" });
            //races.Add( new Race() { RaceID = 2, X = 859, Y = 249, Name = "Losail Circuit" });
            //races.Add( new Race() { RaceID = 3, X = 194, Y = 428, Name = "Autódromo Termas de Río Hondo" });
            //ViewData["RacesList"] = races;
            return View();
        }

        // GET: InfoController
        public ActionResult Index()
        {
            return View();
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
