using Microsoft.AspNetCore.Mvc;
using MetricSystemApp.Models;

namespace MetricSystemApp.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Privacy()
        {
            return View();
        }

        
        [HttpGet]
        public IActionResult Fahrenheit()
        {
            return View(new TempModel());
        }

        
        [HttpPost]
        public IActionResult Fahrenheit(TempModel model)
        {
        
            return View(model);
        }
    }
}