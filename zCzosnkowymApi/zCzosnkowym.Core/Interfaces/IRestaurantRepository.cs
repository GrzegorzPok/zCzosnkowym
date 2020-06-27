using System.Collections.Generic;
using System.Threading.Tasks;

namespace zCzosnkowym.Core.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<IEnumerable<Restaurant>> GetAll();
    }
}