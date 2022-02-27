using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebEmpty.Models;
using CoreWebEmpty.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebEmpty.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public ViewResult Index()
        {
            IEnumerable<Employee> employees = _employeeRepository.GetAll();
            return this.View(employees);
        }

        public ViewResult GetEmployee(int Id = 1)
        {
            Employee employee = _employeeRepository.GetEmployee(Id);
            return this.View(employee);

            //if (employee == null)
            //    return Json("Empty Record");
            //return Json(new { employee.ID, employee.Name, employee.Email, employee.Department });
        }

        public ViewResult GetEmployeeWithView(int Id = 1)
        {
            Employee employee = _employeeRepository.GetEmployee(Id);
            return this.View();
        }

        public ViewResult GetEmployeeWithViewBag(int Id = 1)
        {
            ViewBag.PageTitle = "This is Get Employee With ViewBag";
            Employee employee = _employeeRepository.GetEmployee(Id);
            ViewBag.Employee = employee;
            return this.View();
        }

        public ViewResult GetEmployeeWithViewData(int Id = 1)
        {
            ViewData["PageTitle"] = "This is Get Employee With ViewData";
            Employee employee = _employeeRepository.GetEmployee(Id);
            ViewData["Employee"] = employee;
            return this.View();
        }

        public ViewResult GetEmployeeWithViewModel(int Id = 1)
        {
            Employee employee = _employeeRepository.GetEmployee(Id);
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel
            {
                Employee = employee,
                PageTitle = "This is Get Employee With ViewModel"
            };

            return this.View(employeeDetailsViewModel);
        }
    }
}