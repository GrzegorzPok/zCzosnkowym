using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using zCzosnkowym.Core;
using zCzosnkowym.Core.Interfaces;

namespace zCzosnkowym.DataAccess
{
    public class RestaurantRepository: IRestaurantRepository
    {
        private RestaurantContext _context;

        public RestaurantRepository(RestaurantContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Restaurant>> GetAll()
        {
            _context.Database.EnsureCreated();
            return await _context.Restaurants.ToListAsync();
        }

        public async Task<int> DeleteRestaurant(int id)
        {
            int result = 0;

            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant != null)
            {
                _context.Restaurants.Remove(restaurant);
                result = await _context.SaveChangesAsync();
            }

            return result;
        }
    }
}