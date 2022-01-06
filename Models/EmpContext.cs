using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options){

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmpRole> EmpRoles { get; set; }
    }
}
