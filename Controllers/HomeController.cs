using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // Main page (your calculator will show here)
        public IActionResult Index()
        {
            return View();
        }

        // Optional page (can keep or delete later)
        public IActionResult Privacy()
        {
            return View();
        }

        // Default error page (auto-generated MVC feature)
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}