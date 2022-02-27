using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Models;
using CoreWeb.SeedData;
using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<DepartmentModel> departmentList = DummyData.GetDepartmentListHardCodedData();
            return View(departmentList);
        }
    }
}