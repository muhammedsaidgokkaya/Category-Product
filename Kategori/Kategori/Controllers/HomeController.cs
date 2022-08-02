using Kategori.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Kategori.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Context c = new Context();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var a = c.Urunlers.ToList();
            return View(a);
        }

        public IActionResult CategoryDetails(int id)
        {
            var categoryid = c.Categories.Find(id);
            var icerikler = c.Urunlers.Where(x => x.CategoryId == id).ToList();
            return View(icerikler);
        }
        public IActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kayit(AdminUser form)
        {
            c.AdminUsers.Add(form);
            c.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
        public IActionResult UrunDetails(int? id)
        {
            var urun = c.Urunlers.Find(id);
            return View(urun);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
