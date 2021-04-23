using ASP.NETCORE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCORE.Repositoty;
using ASP.NETCORE.Models;
using Newtonsoft.Json;

namespace ASP.NETCORE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ToysRepositoty toysRepositoty = new ToysRepositoty();

        public IActionResult Index(string CategoryId)
        {
     
            List<Toy> specialToys = toysRepositoty.getAllSpecial();
            //using viewBag /viewData
            ViewBag.SpecialToys = specialToys;
            //ViewData["indexer"] = special;
            List<Toy> toys = null;
            var data = TempData["FilterByCategory"] as string;
            if (data != null)
            {
                var result = JsonConvert.DeserializeObject<List<Toy>>(data);
            }
            if (CategoryId != null)
            {
                toys = toysRepositoty.filterByCategory(CategoryId);
            }
            else
            {
                toys = toysRepositoty.getAllToys();
            }
            //passing data/model to view
            return View(toys);
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
