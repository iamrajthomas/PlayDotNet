using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb.Models
{
    [Table("Department")]
    public class DepartmentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IEnumerable<EmployeeModel> Employees { get; set; }

    }
}
