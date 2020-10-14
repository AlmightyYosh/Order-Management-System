using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Data
{
    //This works as a On-Create to Link the database and create the objects as tables.
    public class ContosoPetsContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Server string link 
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-66MUC5KN;Initial Catalog=EntityFrameworkSandBox;Persist Security Info=True;User ID=sa;Password=password901");

        }

    }
}
