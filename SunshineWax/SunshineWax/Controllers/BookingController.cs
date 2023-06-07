using Microsoft.AspNetCore.Mvc;

namespace SunshineWax.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
