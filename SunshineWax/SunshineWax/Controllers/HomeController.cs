using Microsoft.AspNetCore.Mvc;
using SunshineWax.Data.Repositories.IRepository;
using SunshineWax.Models;
using SunshineWax.Models.BookingModels;
using System.Diagnostics;

namespace SunshineWax.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceRepository _serviceRepo;
        public HomeController(IServiceRepository serviceRepo)
        {
            _serviceRepo = serviceRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Services()
        {
            if(TempData["UserName"] != null)
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
           
            List<Services> serviceList = _serviceRepo.GetAll().ToList();  
            return View(serviceList);
        }
        
        public IActionResult AddServices()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult AddServices(Services service)
        {
            if(service == null)
            {
                return BadRequest();
            }
            _serviceRepo.Add(service);
            _serviceRepo.Save();
            return View("Services");
        }

        public IActionResult EditService(Services service)
        {
            if (service == null)
            {
                return BadRequest();
            }
            _serviceRepo.Add(service);
            _serviceRepo.Save();
            return View("Services");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}