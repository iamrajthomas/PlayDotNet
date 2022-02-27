using EmployeeWeb.Manager;
using EmployeeWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWeb.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        public BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }

        protected Employee _emp;
        public abstract IEmployeeManager Create();

        public Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetPay();
            return _emp;
        }
    }
}