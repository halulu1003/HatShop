using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HATSHOP.Models;

namespace HATSHOP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Browse(string genre)
        {
            var genres = new List<Genre>
           {
              new Genre { Name = "Disco"},
              new Genre { Name = "Jazz"},
              new Genre { Name = "Rock"}
           };
            return View(genres);

        }

        public ActionResult Items(int id)
        {
            var category = new Category { Type = "Category " + id };
            return View(category);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
