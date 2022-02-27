using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebEmpty.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public MockEmployeeRepository()
        {
            GetMockData();
        }

        private void GetMockData()
        {
            _employees = new List<Employee>
            {
                new Employee{ ID= 1, Name = "Alex", Email = "alex@test.com", Department = "IT" },
                new Employee{ ID= 2, Name = "Bruce", Email = "bruce@test.com", Department = "HR" },
                new Employee{ ID= 3, Name = "Maxx", Email = "maxx@test.com", Department = "Admin" },
                new Employee{ ID= 3, Name = "Allen", Email = "allen@test.com", Department = "Cloud" },
                new Employee{ ID= 5, Name = "Mary", Email = "mary@test.com", Department = "Support" }
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employees.Where(emp => emp.ID == Id).FirstOrDefault();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }
    }
}
