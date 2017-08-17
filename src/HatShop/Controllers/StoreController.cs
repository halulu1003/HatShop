using HATSHOP.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HATSHOP.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Details(int id)
        {
            var category = new Category { Type = "Category " + id };
            return View(category);
        }
    }
}
