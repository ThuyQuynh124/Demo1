using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoNetCore.Models;

    public class PersonDBContext : DbContext
    {
        public PersonDBContext (DbContextOptions<PersonDBContext> options)
            : base(options)
        {
        }

        public DbSet<DemoNetCore.Models.Person> Person { get; set; }
    }
