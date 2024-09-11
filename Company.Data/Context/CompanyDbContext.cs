using Company.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Context
{
    public class CompanyDbContext:IdentityDbContext<ApplicationUser>
    {
       
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer("");
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(l => l.UserId);
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(l => l.UserId);
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(l => l.UserId);
            // modelBuilder.Entity<BaseEntity>().HasQueryFilter(x => !x.IsDeleted??false);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department>  Departments { get; set; }
    }
}
