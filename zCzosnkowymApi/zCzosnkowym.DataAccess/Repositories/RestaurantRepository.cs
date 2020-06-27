using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using zCzosnkowym.DataAccess.Context;
using zCzosnkowym.DataAccess.Entities;
using zCzosnkowym.DataAccess.Interfaces;
using System.Linq;
using System.Collections.Generic;
using System;

namespace zCzosnkowym.DataAccess
{
    public class RestaurantRepository: IRestaurantRepository
    {
        private OrderFoodContext _context;

        public RestaurantRepository(OrderFoodContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Restaurant>> GetAll()
        {        
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