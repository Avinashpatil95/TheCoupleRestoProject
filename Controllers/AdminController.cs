using Microsoft.AspNetCore.Mvc;
using RestaurantWebsite.Data;
using RestaurantWebsite.Models;

namespace RestaurantWebsite.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Login page
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var admin = _db.AdminUsers
                .FirstOrDefault(a => a.Username == username && a.Password == password);
            if (admin != null)
            {
                HttpContext.Session.SetInt32("AdminId", admin.Id);
                return RedirectToAction("Index");
            }
            ViewBag.Error = "Invalid credentials";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminId");
            return RedirectToAction("Login");
        }

        // Admin dashboard
        public IActionResult Index()
        {
            if (!HttpContext.Session.Keys.Contains("AdminId"))
                return RedirectToAction("Login");

            return View();
        }
    }
}