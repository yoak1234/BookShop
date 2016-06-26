using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _Menu()
        {
            return PartialView();
        }

        public ActionResult AddProducts()
        {
            return View(new AddProductViewModel());
        }

        [HttpPost]
        public ActionResult AddProducts(AddProductViewModel model)
        {
            
            return View("Index");
        }
    }
}