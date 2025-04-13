using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Demo.Data.Configurations;
using Demo.Data.Models;
using EFCoreFluentApi;
using Microsoft.EntityFrameworkCore;


namespace Demo.Data
{
    internal class CompanyDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = .; DataBase = Company02; Trusted_Connection = True; TrustServerCertificate = True ");
        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Product> products { get; set; } 
        public DbSet<Department> departments { get; set; } //Refernce to the Department table from another project

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
