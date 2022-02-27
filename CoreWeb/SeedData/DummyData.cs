using CoreWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb.SeedData
{
    public class DummyData
    {
        public static List<EmployeeModel> GetEmployeeListWithDepartmentHardCodedData()
        {
            List<EmployeeModel> employeeList = new List<EmployeeModel>();
            employeeList.Add(new EmployeeModel() { EmployeeId = 101, Name = "Jerry", Gender = "Male", City = "Banglore", DepartmentId = 1 });
            employeeList.Add(new EmployeeModel() { EmployeeId = 102, Name = "Maxx", Gender = "Male", City = "Pune", DepartmentId = 1 });
            employeeList.Add(new EmployeeModel() { EmployeeId = 103, Name = "Bruce", Gender = "Female", City = "Mumbai", DepartmentId = 2 });
            employeeList.Add(new EmployeeModel() { EmployeeId = 104, Name = "Alex", Gender = "Male", City = "Hyderabad", DepartmentId = 2 });
            employeeList.Add(new EmployeeModel() { EmployeeId = 105, Name = "William", Gender = "Male", City = "Delhi", DepartmentId = 3 });
            employeeList.Add(new EmployeeModel() { EmployeeId = 106, Name = "Allen", Gender = "Female", City = "Trivandrum", DepartmentId = 3 });
            return employeeList;
        }

        public static List<EmployeeModel> GetEmployeeListHardCodedData()
        {
            List<EmployeeModel> employeeList = new List<EmployeeModel>();
            employeeList.Add(new EmployeeModel() { EmployeeId = 101, Name = "Jerry", Gender = "Male", City = "Banglore" });
            employeeList.Add(new EmployeeModel() { EmployeeId = 102, Name = "Maxx", Gender = "Male", City = "Pune" });
            employeeList.Add(new EmployeeModel() { EmployeeId = 103, Name = "Bruce", Gender = "Female", City = "Mumbai" });
            employeeList.Add(new EmployeeModel() { EmployeeId = 104, Name = "Alex", Gender = "Male", City = "Hyderabad" });
            employeeList.Add(new EmployeeModel() { EmployeeId = 105, Name = "William", Gender = "Male", City = "Delhi" });
            employeeList.Add(new EmployeeModel() { EmployeeId = 106, Name = "Allen", Gender = "Female", City = "Trivandrum" });
            return employeeList;
        }

        public static EmployeeModel GetEmployeeDetailsHardCodedData()
        {
            return new EmployeeModel()
            {
                EmployeeId = 101,
                Name = "Jerry",
                Gender = "Male",
                City = "Banglore"
            };
        }


        public static List<DepartmentModel> GetDepartmentListHardCodedData() 
        {
            List<DepartmentModel> departmentList = new List<DepartmentModel>();

            List<EmployeeModel> employeeList1 = new List<EmployeeModel>();
            List<EmployeeModel> employeeList2 = new List<EmployeeModel>();
            List<EmployeeModel> employeeList3 = new List<EmployeeModel>();
            employeeList1.Add(new EmployeeModel() { EmployeeId = 101, Name = "Jerry", Gender = "Male", City = "Banglore", DepartmentId = 1 });
            employeeList1.Add(new EmployeeModel() { EmployeeId = 102, Name = "Maxx", Gender = "Male", City = "Pune", DepartmentId = 1 });
            employeeList2.Add(new EmployeeModel() { EmployeeId = 103, Name = "Bruce", Gender = "Female", City = "Mumbai", DepartmentId = 2 });
            employeeList2.Add(new EmployeeModel() { EmployeeId = 104, Name = "Alex", Gender = "Male", City = "Hyderabad", DepartmentId = 2 });
            employeeList3.Add(new EmployeeModel() { EmployeeId = 105, Name = "William", Gender = "Male", City = "Delhi", DepartmentId = 3 });
            employeeList3.Add(new EmployeeModel() { EmployeeId = 106, Name = "Allen", Gender = "Female", City = "Trivandrum", DepartmentId = 3 });

            departmentList.Add(new DepartmentModel()
            {
                ID = 1,
                Name = "IT",
                Employees = employeeList1
            });

            departmentList.Add(new DepartmentModel()
            {
                ID = 2,
                Name = "HR",
                Employees = employeeList2
            });

            departmentList.Add(new DepartmentModel()
            {
                ID = 3,
                Name = "CTO",
                Employees = employeeList3
            });

            return departmentList;
        }



    }
}
