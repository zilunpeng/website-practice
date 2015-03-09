using fruitland.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fruitland.Controllers
{
    public class HomeController : Controller
    {
        private IFruitRepo _repo;

        public HomeController(IFruitRepo repo)
        {
            _repo = repo; 
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var fruits = _repo.getFruits().OrderByDescending(t => t.Id).Take(25).ToList();

            return View(fruits);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
