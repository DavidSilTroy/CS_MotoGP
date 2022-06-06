using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MotoGP.Data;
using MotoGP.Models;
using MotoGP.Models.ViewModels;
using System;
using System.Linq;

namespace MotoGp.Controllers
{
    public class ShopController : Controller
    {
        private readonly GPContext _context;
        public ShopController( GPContext context)
        {
            _context = context;
        }



        // GET: ShopController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult OrderTicket()
        {
            ViewData["Title"] = "Order Tickets";
            ViewData["BannerNr"] = 3;
            var listCountries = new CountriesForTicketsViewModel();
            listCountries.Countries = new SelectList(_context.Countries.OrderBy(c => c.CountryID),"CountryID" ,"Name");
            return View(listCountries);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmOrder(
            [Bind("Name,Email,Address,Number")] Ticket ticket, CountriesForTicketsViewModel countrySelect)
        {
            var date = DateTime.UtcNow;
            ViewBag.ticketInfo = "Error";
            ViewData["Title"] = "Confirmation";
            ViewData["CurrentDateConfirm"] = date.ToString("dd-MM-yyyy");
            ViewData["BannerNr"] = 3;

            ticket.CountryID = countrySelect.CountryID;
            ticket.RaceID = 1;
            ticket.OrderDate = date;
            ticket.Paid = true;
            if (ModelState.IsValid && ticket.CountryID!=0)
            {
                _context.Add(ticket);
                _context.SaveChanges();
                ViewBag.ticketInfo = "Done";    
                return View();
            }
            //ViewBag.ticketInfo = "Error: CountryID: " + ticket.CountryID + "Extra: " + countryThing.CountryID;
            return View();
        }

        // GET: ShopController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShopController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: ShopController/Create
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

        // GET: ShopController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopController/Edit/5
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

        // GET: ShopController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopController/Delete/5
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
