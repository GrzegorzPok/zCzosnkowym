using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zCzosnkowym.Api.Enums;

namespace zCzosnkowym.Api.Models
{
    public class OrderDto
    {
        public int Id { get; set; }
        public OrderState State { get; set; }
        public string Name { get; set; }
        public DateTime OrderingDate { get; set; }
        public string Purchaser { get; set; }
    }
}
