using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreWeb.Models;

namespace CoreWeb.Controllers
{
    public class HomeController : Controller
    {
        public string Index1()
        {
            return "Hello From Web Core Application";
        }

        public string Index(int Id, string Name)
        {
            return "Hello From Web Core Application ==> ID: " + Id + " ==> Name: " + Name;
        }

        public IActionResult PrintCountryListUsingViewBag() 
        {
            ViewBag.CountryList = new List<string>()
            {
                "India", "US", "UK", "Aus", "Canada"
            };
            return View();
        }

        public IActionResult PrintCountryListUsingViewData()
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
