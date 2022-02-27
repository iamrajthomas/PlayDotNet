using EmployeeWeb.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWeb.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int empTypeId)
        {
            IEmployeeManager employeeManager = null;
            if (empTypeId == 1)
            {
                employeeManager = new PermanentEmployeeManager();
            }
            else if (empTypeId == 2)
            {
                employeeManager = new ContractEmployeeManager();
            }
            return employeeManager;
        } 
    }
}