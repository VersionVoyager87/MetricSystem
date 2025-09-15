using Microsoft.AspNetCore.Mvc;
using MetricSystemApp.Models;

namespace MetricSystemApp.Controllers
{
    public class ConversionsController : Controller
    {
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
