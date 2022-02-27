using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeeWeb.Factory.AbstractFactory.Enumerations;

namespace EmployeeWeb.Factory.AbstractFactory
{
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Desktop.ToString();
        }
    }
}