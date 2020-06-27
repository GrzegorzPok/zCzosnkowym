using System;
using System.Collections.Generic;
using System.Text;

namespace zCzosnkowym.Core.Interfaces
{
    public interface IFoodOrderRepository
    {
        int Save(Order order);
    }
}
