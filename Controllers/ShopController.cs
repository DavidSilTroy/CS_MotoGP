using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotoGP.Data;
using MotoGP.Models;
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
            //var ticktes = _context.Tickets;
            return View() ;
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmOrder([Bind("Name,Email,Address,Number")] Ticket ticket)
        {
            var date = DateTime.UtcNow;
            ViewBag.ticketInfo = "Error";
            ViewData["Title"] = "Confirmation";
            ViewData["CurrentDateConfirm"] = date.ToString("dd-MM-yyyy");
            ViewData["BannerNr"] = 3;
            ticket.CountryID = 1;
            ticket.RaceID = 1;
            ticket.OrderDate = date;
            ticket.Paid = true;
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                _context.SaveChanges();
                ViewBag.ticketInfo = "Done";    
                return View();
            }
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
