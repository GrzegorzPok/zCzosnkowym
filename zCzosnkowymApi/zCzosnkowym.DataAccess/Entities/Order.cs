using System;
using System.Collections.Generic;
using System.Text;

namespace zCzosnkowym.DataAccess.Entities
{

    public partial class Order
    {
        public Order()
        {
            Elements = new HashSet<OrderElement>();
        }

        public int Id { get; set; }
        public int State { get; set; }
        public string Name { get; set; }
        public DateTime OrderingDate { get; set; }
        public string PurchaserName { get; set; }
        public string PurchaserAccountNumber { get; set; }
        public int CreatorId { get; set; }
        public int? PurchaserId { get; set; }
        public int RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual Person Purchaser { get; set; }
        public virtual ICollection<OrderElement> Elements { get; set; }
    }

}
