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
            optionsBuilder.UseSqlServer(@"(localdb)\mssqllocaldb;Database=ReCapProjectDB;trusted_connection=true");
        }
        public DbSet<Car> Tbl_Cars;
        public DbSet<Color> Tbl_Color;
        public DbSet<Brand> Tbl_Brand;
    }
}
