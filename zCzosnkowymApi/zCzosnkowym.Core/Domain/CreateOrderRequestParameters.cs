using System;

namespace zCzosnkowym.Core
{ 
    public class CreateOrderParameters
    {
        public CreateOrderParameters()
        {
        }

        public Restaurant Restaurant { get;  set; }
        public Person OrderOwner { get; set; }
        public DateTime OrderingDate { get; set; }
        public string Name { get; set; }
    }
}