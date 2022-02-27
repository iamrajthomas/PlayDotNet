using EmployeeWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWeb.Factory.FactoryMethod
{
    public class EmployeeManagerFactoryMethod
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            BaseEmployeeFactory returnValue = null;
            if(employee.Employee_TypeId == 1)
            {
                returnValue = new PermanentEmployeeFactory(employee);
            }
            else if (employee.Employee_TypeId == 2)
            {
                returnValue = new ContractEmployeeFactory(employee);
            }
            return returnValue;

        }
    }
}