using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCScaffoldingDemo.Models
{
    public class EmpDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}

