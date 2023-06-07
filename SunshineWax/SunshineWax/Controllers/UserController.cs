using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SunshineWax.Controllers
{   
    public class UserController : Controller
    {
        [Authorize("Sagar")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
