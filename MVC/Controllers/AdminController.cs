using Core.Models.UserSide;
using DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly Context _context;

        public AdminController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public IActionResult Index(string UserName, string UserPassword)
        {
            User user = _context.Users.FirstOrDefault(m => m.Name == UserName && m.Password == UserPassword);            

            if (user == null)
            {
                ViewBag.LoginError = "Hatalı kullanıcı bilgileri";
              
                return View();
            }

            else
            {
                switch (user.RoleID)  //0 sysadmin, 1 admin, 2 customer
                {
                    case 1:
                        return RedirectToAction("Index", "Product");
                        break;
                    case 2:
                        return RedirectToAction("AdminIndex", "Product");
                        break;
                    case 3:
                        return RedirectToAction("CustomerIndex", "Product");
                        break;
                    default:
                        return RedirectToAction("CustomerIndex", "Product");
                        break;
                }
            }
           //role gore yonlendirme yapıldıktan sonra oturum kontrolunden gecerse sayfalar gosterilir.

        }


    }
}
