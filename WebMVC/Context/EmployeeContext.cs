using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebMVC.Models;

namespace WebMVC.Context
{
    public class EmployeeContext : DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set; }

    }
}