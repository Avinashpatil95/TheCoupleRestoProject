using Microsoft.AspNetCore.Mvc;
using RestaurantWebsite.Data;
using System.Linq;

namespace RestaurantWebsite.Controllers
{
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MenuController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = _context.MenuItems.ToList();
            return View(items);
        }
    }
}