using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLogin.Models;

namespace WpfLogin.Context
{
    public class MyContext : DbContext
     {
        public MyContext()
                : base("DbConnectionString")
        {
        }
            public DbSet<User> Users { get; set; }
            public DbSet<Employee> Employees { get; set; }
      

    }
}
