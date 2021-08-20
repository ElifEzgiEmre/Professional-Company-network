using Microsoft.EntityFrameworkCore;
using Proje1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje1.Context
{
    public class MyContext : DbContext
    {
        public MyContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=DbProje;integrated security=true");
        }

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { }


        public DbSet<Person> Persons { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Education { get; set; }
    }
}
