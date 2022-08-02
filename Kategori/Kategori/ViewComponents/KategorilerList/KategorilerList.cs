using Kategori.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kategori.ViewComponents.KategorilerList
{
    public class KategorilerList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var d = c.Categories.ToList();
            return View(d);
        }
    }
}
