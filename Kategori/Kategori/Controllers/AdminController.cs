using Kategori.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kategori.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IWebHostEnvironment _hostEnvironment;
        Context c = new Context();
        public AdminController(ILogger<AdminController> logger, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateUrun()
        {
            Context c = new Context();
            var value = c.Categories.ToList();
            List<SelectListItem> CategoryList = (from x in value
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryId.ToString()
                                                 }).ToList();
            ViewBag.Category = CategoryList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUrunAsync(Urunler p)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(p.ImgFile.FileName);
                string extension = Path.GetExtension(p.ImgFile.FileName);
                p.ImgName = filename = filename + extension;//yol == path
                string path = Path.Combine(wwwRootPath + "/Image/", filename);  // + DateTime.Now.ToString("yymmssfff") 
                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    await p.ImgFile.CopyToAsync(filestream);    //.CopyToAsync
                }
                c.Urunlers.Add(p);
                c.SaveChanges();
            }
            return RedirectToAction("IndexUrun", "Admin");
        }

        public IActionResult IndexUrun()
        {
            var a = c.Urunlers.ToList();
            return View(a);
        }

        public IActionResult DeleteUrun(int id)
        {
            var sil = c.Urunlers.Find(id);
            c.Urunlers.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("IndexUrun", "Admin");
        }

        public IActionResult UpdateUrun(int id)
        {
            Context c = new Context();
            var value = c.Categories.ToList();
            List<SelectListItem> CategoryList = (from x in value
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryId.ToString()
                                                 }).ToList();
            ViewBag.Category = CategoryList;
            var guncelle = c.Urunlers.Find(id);
            return View(guncelle);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUrunAsync(Urunler p)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(p.ImgFile.FileName);
                string extension = Path.GetExtension(p.ImgFile.FileName);
                p.ImgName = filename = filename + extension;//yol == path
                string path = Path.Combine(wwwRootPath + "/Image/", filename);  // + DateTime.Now.ToString("yymmssfff") 
                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    await p.ImgFile.CopyToAsync(filestream);    //.CopyToAsync
                }
                c.Urunlers.Update(p);
                c.SaveChanges();
            }
            return RedirectToAction("IndexUrun", "Admin");
        }
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category form)
        {
            c.Categories.Add(form);
            c.SaveChanges();
            return RedirectToAction("IndexCategory", "Admin");
        }

        public IActionResult IndexCategory()
        {
            var x = c.Categories.ToList();
            return View(x);
        }

        public IActionResult DeleteCategory(int id)
        {
            var sil = c.Categories.Find(id);
            c.Categories.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("IndexCategory", "Admin");
        }

        public IActionResult UpdateCategory(int id)
        {
            var guncelle = c.Categories.Find(id);
            return View(guncelle);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category form)
        {
            c.Categories.Update(form);
            c.SaveChanges();
            return RedirectToAction("IndexCategory", "Admin");
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }

    }
}
