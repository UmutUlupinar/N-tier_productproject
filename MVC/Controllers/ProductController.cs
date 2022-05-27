﻿using Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    [Authorize](Roles="Admin")]
    public class ProductController : Controller
    {
        private IProductService _proService;

        public ProductController(IProductService proService)
        {
            _proService = proService;
        }

        //role göre faklı viewlere yönlendirilir.Dısarıdan erisim authorize ile engellendi.
        //dısarıdan erismde veya farklı yanlıs girisimde login sayfasına yonlendirilir.
        //bu sekilde loginden gecmeden sysadmin,admin veya customer sayfasından gecemezsin.
                

        //[Authorize(Roles = "Admin")]  //authorize by role
        public IActionResult Index()
        {
            var values = _proService.GetAllAsync();
            return View(values);
        }

        //[Authorize(Roles = "Admin")]
        public IActionResult AdminIndex(int id)  //category id
        {
            var values = _proService.GetByIdAsync(id);
            return View(values);
        }

        //[Authorize(Roles = "Admin")]
        public IActionResult CustomerIndex()
        {
            var values = _proService.GetAllAsync();
            return View(values);
        }

  

        //Index tarafında bütün ürünler çekilebiliniyor.güncelleme ve silme işlemleri yapılabiliniyor
        //Admin Index tarafında Adminin ait olduğu Marka-kategoriye göre ürünler çekilebiliniyor.güncelleme ve silme işlemleri yapılabiliniyor
        // Customer tarafında sadece sipariş verme işlemi yapılabiliniyor.
    }
}
