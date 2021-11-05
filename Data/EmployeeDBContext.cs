using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoNetCore.Models;

    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext (DbContextOptions<EmployeeDBContext> options)
            : base(options)
        {
        }

        public DbSet<DemoNetCore.Models.Employee> Employee { get; set; }
    }
