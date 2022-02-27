using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Context;
using CoreWeb.Models;
using CoreWeb.SeedData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index(int departmentId)
        {
            List<EmployeeModel> employeeList = DummyData.GetEmployeeListWithDepartmentHardCodedData()
                                                        .Where(x => x.DepartmentId == departmentId).ToList();

            return View(employeeList);
        }

        //public IActionResult Index()
        //{
        //    List<EmployeeModel> employeeList = DummyData.GetEmployeeListHardCodedData();

        //    return View(employeeList);
        //}



        public IActionResult Details(int Id)
        {
            //EmployeeModel employee = DummyData.GetEmployeeDetailsHardCodedData();
            //EmployeeModel employee = DummyData.GetEmployeeListHardCodedData().Single(x => x.EmployeeId == Id);
            EmployeeModel employee = DummyData.GetEmployeeListWithDepartmentHardCodedData().Where(x => x.EmployeeId == Id).FirstOrDefault();

            return View(employee);

        }

        [HttpGet]
        [ActionName("Create")]
        public IActionResult Create_Get()
        {
            return View();
        }

        //[HttpPost]
        //[ActionName("Create")]
        //public IActionResult Create_PostWithFormCollection(IFormCollection form)
        //{
        //    foreach (var key in form.Keys)
        //    {
        //        Response.WriteAsync("Keys: " + key + " ==> Value: " + form[key]);
        //    }

        //    EmployeeModel emp = new EmployeeModel();
        //    emp.EmployeeId = Convert.ToInt32(form["EmployeeId"]);
        //    emp.Name = form["Name"];
        //    emp.Gender = form["Gender"];
        //    emp.City = form["City"];

        //    return View();
        //}

        //[HttpPost]
        //[ActionName("Create")]
        //public IActionResult Create_PostWithFormVariables(int EmployeeId, string Name, string Gender, string City, int DepartmentId)
        //{
        //    return View();
        //}


        //[HttpPost]
        //[ActionName("Create")]
        //public IActionResult Create_PostEmployeeModel(EmployeeModel emp)
        //{

        //    return View();
        //}

        //[HttpPost]
        //[ActionName("Create")]
        //public IActionResult Create_PostWithUpdateModel()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        EmployeeModel emp = new EmployeeModel();
        //        TryUpdateModelAsync(emp);

        //        //Add logic to save data to DB

        //        //Redirect to Index Page of Employee
        //        return RedirectToAction("Index", "Employee", new { departmentId = 1 }, null);
        //    }

        //    return View();
        //}

        [HttpPost]
        [ActionName("Create")]
        public IActionResult Create_PostWithTryUpdateModel()
        {
            EmployeeModel emp = new EmployeeModel();
            TryUpdateModelAsync(emp);

            if (ModelState.IsValid)
            {

                //Add logic to save data to DB

                //Redirect to Index Page of Employee
                return RedirectToAction("Index", "Employee", new { departmentId = 1 }, null);
            }

            return View();
        }

        /// <summary>
        /// Will get this done later
        /// Need DB con establishment and fetch records
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        //public IActionResult DetailsFromDB(int Id)
        //{
        //    EmployeeContext employeeContext = new EmployeeContext();
        //    EmployeeModel employee = employeeContext.Employee.Single(x => x.EmployeeId == Id);
        //    return View(employee);
        //}
    }
}