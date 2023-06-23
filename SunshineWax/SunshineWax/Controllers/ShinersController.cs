using Microsoft.AspNetCore.Mvc;
using SunshineWax.Data.Repositories.IRepository;
using SunshineWax.Models.BookingModels;

namespace SunshineWax.Controllers
{
    public class ShinersController : Controller
    {
        private readonly IShinersRepository _shinersRepo;
        public ShinersController(IShinersRepository shinersRepo)
        {
            _shinersRepo = shinersRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Services()
        {
            if (TempData["UserName"] != null)
            {
                var userValue = TempData["UserName"].ToString();
                if (userValue == "sumi")
                {
                    ViewData["allowUser"] = "yes";
                }
                else
                {
                    ViewData["allowUser"] = "no";

                }
            }
            else
            {
                ViewData["allowUser"] = null;
            }

            List<Sunshiners> serviceList = _shinersRepo.GetAll().ToList();
            return View(serviceList);
        }

        public IActionResult AddServices()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddServices(Sunshiners shiners)
        {
            if (shiners == null)
            {
                return BadRequest();
            }
            _shinersRepo.Add(shiners);
            _shinersRepo.Save();
            return View("Services");
        }

        public IActionResult EditService(Sunshiners shiners)
        {
            if (shiners == null)
            {
                return BadRequest();
            }
            _shinersRepo.Add(shiners);
            _shinersRepo.Save();
            return View("Services");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
    }
}
