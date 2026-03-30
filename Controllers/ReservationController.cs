using Microsoft.AspNetCore.Mvc;
using RestaurantWebsite.Data;
using RestaurantWebsite.Models;

namespace RestaurantWebsite.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Show form
        public IActionResult Create()
        {
            return View();
        }

        // Save booking
        [HttpPost]
        public IActionResult Create(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Reservations.Add(reservation);
                _context.SaveChanges();
                return RedirectToAction("Success");
            }
            return View(reservation);
        }

        // Success page
        public IActionResult Success()
        {
            return View();
        }
    }
}