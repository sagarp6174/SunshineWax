using Microsoft.AspNetCore.Mvc;
using SunshineWax.Data.Data;
using SunshineWax.Models.UserModels;

namespace SunshineWax.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {            
            _db.Users.Add(user);
            _db.SaveChanges();
            return View("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if(user == null)
            {
                return BadRequest();
            }

            var userNameFromDb = _db.Users.FirstOrDefault(x => x.UserName == user.UserName).UserName;
            var passwordFromDb = _db.Users.FirstOrDefault(x => x.UserName == user.UserName).Password;
            if (userNameFromDb != null && passwordFromDb != null)
            {
                if(user.UserName == userNameFromDb && user.Password == passwordFromDb)
                {                    
                    TempData["UserName"] = user.UserName;
                    return RedirectToAction("Index", "Home");
                }
            }            
            return View();            
        }
    }
}
