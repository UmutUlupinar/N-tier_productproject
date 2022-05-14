using Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _proService;

        public ProductController(IProductService proService)
        {
            _proService = proService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var values = _proService.GetAllAsync();
            return View(values);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AdminIndex(int id)  //category id
        {
            var values = _proService.GetByIdAsync(id);
            return View(values);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult CustomerIndex()
        {
            var values = _proService.GetAllAsync();
            return View(values);
        }
    }
}
