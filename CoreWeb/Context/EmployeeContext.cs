using CoreWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb.Context
{
    public class EmployeeContext : DbContext
    {
        public DbSet<EmployeeModel> Employee { get; set; }
    }
}
