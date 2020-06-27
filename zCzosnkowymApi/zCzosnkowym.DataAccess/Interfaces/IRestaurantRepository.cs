using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zCzosnkowym.DataAccess.Entities;

namespace zCzosnkowym.DataAccess.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<IEnumerable<Restaurant>> GetAll();
    }
}
