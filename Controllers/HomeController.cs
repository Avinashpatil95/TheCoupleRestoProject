using Microsoft.AspNetCore.Mvc;
using RestaurantWebsite.Data;
using System.Linq;

namespace RestaurantWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var menu = _context.MenuItems.Take(6).ToList(); // show top items
            return View(menu);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}