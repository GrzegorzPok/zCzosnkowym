using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using zCzosnkowym.DataAccess.Entities;

namespace zCzosnkowym.DataAccess.Context
{
    public class OrderFoodContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<OrderElement> OrderElements { get; set; }


        public OrderFoodContext(DbContextOptions<OrderFoodContext> options) : base(options)
        {

        }
    }    
}
