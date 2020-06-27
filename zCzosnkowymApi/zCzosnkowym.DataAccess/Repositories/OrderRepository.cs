using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zCzosnkowym.DataAccess.Context;
using zCzosnkowym.DataAccess.Entities;
using zCzosnkowym.DataAccess.Interfaces;

namespace zCzosnkowym.DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private OrderFoodContext _context;

        public OrderRepository(OrderFoodContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }      
    }
}
