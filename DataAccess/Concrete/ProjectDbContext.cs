using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class ProjectDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"(localdb)\mssqllocaldb;Database=ReCapProjectDB;trusted_connection=true");
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDb;Database=ReCapProjectDB;Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        public DbSet<Car> Tbl_Cars { get; set; }

        public DbSet<Color> Tbl_Color { get; set; }
        public DbSet<Brand> Tbl_Brand { get; set; }
    }
}
