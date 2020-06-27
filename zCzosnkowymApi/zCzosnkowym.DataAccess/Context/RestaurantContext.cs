using Microsoft.EntityFrameworkCore;
using zCzosnkowym.Core;

namespace zCzosnkowym.DataAccess
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }        

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {

        }
    }
}