using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWeb.Manager
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 8;
        }

        public decimal GetPay()
        {
            return 10;
        }
        public decimal GetMedicalAllownace()
        {
            return 100;
        }
    }
}