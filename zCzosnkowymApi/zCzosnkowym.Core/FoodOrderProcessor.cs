using System;
using System.Collections.Generic;
using System.Text;
using zCzosnkowym.Core.Interfaces;

namespace zCzosnkowym.Core
{
    public class FoodOrderProcessor
    {
        private IFoodOrderRepository _foodOrderRepository;

        public FoodOrderProcessor(IFoodOrderRepository foodOrderRepository)
        {
            _foodOrderRepository = foodOrderRepository;
        }

        public Order CreateNewFoodOrder(CreateOrderParameters parameters)
        {
            if(parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var newOrder = new Order();
            newOrder.State = OrderState.New;
            newOrder.Name = parameters.Name;
            newOrder.OrderingDate = parameters.OrderingDate;
            newOrder.Purchaser = parameters.OrderOwner;
            newOrder.Restaurant = parameters.Restaurant;
            
            if(parameters.OrderOwner != null)
            {
                newOrder.PurchaserAccountNumber = parameters.OrderOwner.BankAccount;
                newOrder.PurchaserName = parameters.OrderOwner.FirstName + " " + parameters.OrderOwner.LastName;
            }

            var id = _foodOrderRepository.Save(newOrder);
            newOrder.Id = id;

            return newOrder;
        }

    }
}
