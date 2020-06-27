using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zCzosnkowym.Api.Enums;
using zCzosnkowym.DataAccess.Entities;

namespace zCzosnkowym.Api.Models
{
    public class OrderDetails
    {
       
            public int Id { get; set; }
            public OrderState State { get; set; }
            public string Name { get; set; }
            public DateTime OrderingDate { get; set; }
            public PersonDto Purchaser { get; set; }
            public string PurchaserName { get; set; }
            public string PurchaserAccountNumber { get; set; }
            public RestaurantDto Restaurant { get; set; }
            public IEnumerable<OrderElement> Elements { get; set; }
        
    }
}
