using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello From MVC Web Application!!! MVC Version: "
                + typeof(Controller).Assembly.GetName().Version.ToString();
        }

        //public string Index(int Id, string Name)
        //{
        //    return "Hello From MVC Web Application!!! ==> ID: " + Id + " ==> Name: " + Name;
        //}

        public ActionResult PrintCountryListUsingViewBag()
        {
            ViewBag.CountryList = new List<string>()
            {
                "India", "US", "UK", "Aus", "Canada"
            };
            return View();
        }

        public ActionResult PrintCountryListUsingViewData()
        {
            ViewData["Countries"] = new List<string>()
            {
                "India", "US", "UK", "Aus", "Canada"
            };
            return View();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}