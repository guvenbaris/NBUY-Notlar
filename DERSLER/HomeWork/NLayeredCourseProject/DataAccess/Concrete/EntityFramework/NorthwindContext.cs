using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=GVNBRS\MSSQLSERVER01;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
