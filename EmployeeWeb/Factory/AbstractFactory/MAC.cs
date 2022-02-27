using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeeWeb.Factory.AbstractFactory.Enumerations;

namespace EmployeeWeb.Factory.AbstractFactory
{
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return Brands.APPLE.ToString();
        }
    }
}