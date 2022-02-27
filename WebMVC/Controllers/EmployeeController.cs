using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Context;
using WebMVC.Models;
using WebMVC.Seed;

namespace WebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //public ActionResult Index()
        //{
        //    List<EmployeeModel> employeeList = DummyData.GetEmployeeListHardCodedData();
        //    return View(employeeList);
        //}

        public ActionResult Index(int departmentId = 0)
        {
            //Get Data From Seed Hardcode
            //List<EmployeeModel> employeeList = DummyData.GetEmployeeListHardCodedData();
            //List<EmployeeModel> employeeList = DummyData.GetEmployeeListWithDepartmentHardCodedData().Where(x => x.DepartmentId == departmentId).ToList();

            //Get Data From DB
            EmployeeContext employeeContext = new EmployeeContext();

            List<EmployeeModel> employeeList = employeeContext.Employees.ToList();
            //List<EmployeeModel> employeeList = employeeContext.Employees.Where(x => x.DepartmentId == departmentId).ToList();
            return View(employeeList);
        }



        public ActionResult Details(int Id)
        {
            //EmployeeModel employee = DummyData.GetEmployeeDetailsHardCodedData();
            //EmployeeModel employee = DummyData.GetEmployeeListHardCodedData().Single(x => x.EmployeeId == Id);
            EmployeeModel employee = DummyData.GetEmployeeListWithDepartmentHardCodedData().Where(x => x.EmployeeId == Id).FirstOrDefault();

            //Get Data From DB
            //EmployeeContext context = new EmployeeContext();
            //EmployeeModel employee = context.Employees.Where(emp => emp.EmployeeId == 1).FirstOrDefault();


            return View(employee);

        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        //[HttpPost]
        //[ActionName("Create")]
        //public ActionResult Create_PostWithFormCollection(IFormCollection form)
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
        //public ActionResult Create_PostWithFormVariables(int EmployeeId, string Name, string Gender, string City, int DepartmentId)
        //{
        //    return View();
        //}


        //[HttpPost]
        //[ActionName("Create")]
        //public ActionResult Create_PostEmployeeModel(EmployeeModel emp)
        //{

        //    return View();
        //}

        //[HttpPost]
        //[ActionName("Create")]
        //public ActionResult Create_PostWithUpdateModel()
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
        public ActionResult Create_PostWithTryUpdateModel()
        {
            EmployeeModel emp = new EmployeeModel();
            UpdateModel(emp);

            if (ModelState.IsValid)
            {

                //Add logic to save data to DB

                //Redirect to Index Page of Employee
                return RedirectToAction("Index", "Employee", new { departmentId = 1 });
            }

            return View();
        }


        public string SomeError()
        {
            throw new Exception();
        }
    }
}