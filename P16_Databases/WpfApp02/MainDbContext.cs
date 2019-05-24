﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp02
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(string connectionString)
            : base(connectionString)
        { }

        public DbSet<Employee> Employees { get; set; }

    }
}
