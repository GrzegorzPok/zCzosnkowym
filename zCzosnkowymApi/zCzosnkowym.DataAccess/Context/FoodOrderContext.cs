using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using zCzosnkowym.Core;

namespace zCzosnkowym.DataAccess.Context
{
    public class FoodOrderContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Person> Persons { get; set; }

        public FoodOrderContext(DbContextOptions<FoodOrderContext> options) : base(options)
        {

        }
    }    
}
