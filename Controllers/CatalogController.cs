using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCORE.Repositoty;
using ASP.NETCORE.Models;

namespace ASP.NETCORE.Controllers
{
    [Route ("catalog")]
    public class CatalogController : Controller
    {
        private ToysRepositoty toysRepositoty = new ToysRepositoty();

        //GET /<controller>/
        [Route("details/{id}")]
        public IActionResult productDetails(int id)
        {
            Toy toy = toysRepositoty.getDetails("" + id);
            return View("details", toy);
        }
        public IActionResult FilterByCategory(string id)
        {
            List<Toy> toys = toysRepositoty.filterByCategory(id);
            ViewBag.FilterByCategory = toys;

            // SearchResult result = new SearchResult() { 
            //      cat = new Category() { CCategoryId="9999", CCategory="test" } };

            //TempData["FilterByCategory"] = stoys;

            return RedirectToAction("index", "Home", new { CategoryId = id });
        }

    }
}
