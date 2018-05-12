using HellowMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HellowMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var cars = HelloModel.GetCars();
            ViewBag.DustinCreatedThisValue = "Hello MVC";
            return View(cars);
        }
    }
}