using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeWeb.Factory.AbstractFactory;
using EmployeeWeb.Factory.FactoryMethod;
using EmployeeWeb.Models;

namespace EmployeeWeb.Controllers
{
    public class EmployeesController : BaseController
    {
        private EmployeePortalEntities2 db = new EmployeePortalEntities2();

        // GET: Employees
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Employee_Type);
            return View(employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.Employee_TypeId = new SelectList(db.Employee_Type, "Id", "Name");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Job,Number,Department,HourlyPay,Bonus,Employee_TypeId,HouseAllowance,MedicalAllowance,ComputerDetails")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                // Tightly Coupled Code
                //if (employee.Employee_TypeId == 1)
                //{
                //    employee.HourlyPay = 12;
                //    employee.Bonus = 10;
                //}
                //else if (employee.Employee_TypeId == 2)
                //{
                //    employee.HourlyPay = 10;
                //    employee.Bonus = 8;
                //}

                // Use Factory Here
                //EmployeeManagerFactory empFactory = new EmployeeManagerFactory();
                //IEmployeeManager empManager = empFactory.GetEmployeeManager(employee.Employee_TypeId);
                //employee.Bonus = empManager.GetBonus();
                //employee.HourlyPay = empManager.GetPay();

                // Use Factory Method Here
                BaseEmployeeFactory empFactory = new EmployeeManagerFactoryMethod().CreateFactory(employee);
                empFactory.ApplySalary();

                // Use Abstract Factory Here
                IComputerFactory factory = new EmployeeSystemFactory().Create(employee);
                EmployeeSystemManager manager = new EmployeeSystemManager(factory);
                employee.ComputerDetails = manager.GetSystemDetails();

                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Employee_TypeId = new SelectList(db.Employee_Type, "Id", "Name", employee.Employee_TypeId);
            return View(employee);
        }

        [HttpGet]
        public ActionResult BuildSystem(int? employeeID)
        {

            return View(employeeID);
        }

        [HttpPost]
        public ActionResult BuildSystem(int employeeID, string RAM, string HDDSize)
        {
            Employee employee = db.Employees.Find(employeeID);
            ComputerSystem computerSystem = new ComputerSystem(RAM, HDDSize);
            employee.SystemConfigruationDetails = computerSystem.Build();
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.Employee_TypeId = new SelectList(db.Employee_Type, "Id", "Name", employee.Employee_TypeId);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Job,Number,Department,HourlyPay,Bonus,Employee_TypeId,HouseAllowance,MedicalAllowance,ComputerDetails")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Employee_TypeId = new SelectList(db.Employee_Type, "Id", "Name", employee.Employee_TypeId);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
