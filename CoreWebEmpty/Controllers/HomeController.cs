using CoreWebEmpty.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebEmpty.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public JsonResult Index(int Id = 1) 
        {
            var result = _employeeRepository.GetEmployee(Id);
            if (result == null)
                return Json("Empty Record");
            return Json(new { result.ID, result.Name, result.Email, result.Department });
        }

        //public string Index()
        //{
        //    return "Hello From MVC Home Controller Index Action Method";
        //}

        public JsonResult Details()
        {
            return Json(new { ID = 101, Name = "Hello From MVC Home Controller Details Action Method " });
        }
    }
}
