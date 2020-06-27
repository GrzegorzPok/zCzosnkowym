using System;
using System.Collections.Generic;

namespace zCzosnkowym.Core
{
    public class Order
    {
        public int Id { get; set; }
        public int State { get; set; }
        public string Name { get; set; }
        public DateTime OrderingDate { get; set; }
        public Person Purchaser { get; set; }
        public string PurchaserName { get; set; }
        public string PurchaserAccountNumber { get; set; }
        public Restaurant Restaurant { get; set; }
        public IEnumerable<OrderElement> Elements { get; set; }
    }
}
