using Moq;
using System;
using Xunit;
using zCzosnkowym.Core.Interfaces;

namespace zCzosnkowym.Core.Tests
{
    public class FoodOrderProcessorTest
    {
        private Mock<IFoodOrderRepository> _foodOrderRepositoryMock;
        private FoodOrderProcessor _foodOrderProcessor;
        private CreateOrderParameters _createOrderParameters;

        public FoodOrderProcessorTest()
        {

            _foodOrderRepositoryMock = new Mock<IFoodOrderRepository>();



            _foodOrderProcessor = new FoodOrderProcessor(_foodOrderRepositoryMock.Object);

            _createOrderParameters = new CreateOrderParameters()
            {
                Name = "Ramzes Dziœ",
                Restaurant = new Restaurant()
                {
                    Name = "Ramzes",
                    Website = "pyszne.pl/menu/ramzes-i"

                },

                OrderOwner = new Person()
                {
                    FirstName = "Tomasz",
                    LastName = "Zet",
                    BankAccount = "1231 1234 5454 54545 4545"
                },

                OrderingDate = new DateTime(2020, 06, 26, 11, 30, 00),

            };
        }

        [Fact]
        public void ShouldThrowExceptionIfParametersIsNull()
        {

            //Act
            var exception = Assert.Throws<ArgumentNullException>(
                () => _foodOrderProcessor.CreateNewFoodOrder(null));

            //Assert
            Assert.Equal("parameters", exception.ParamName);

        }

        [Fact]
        public void ShouldCreateNewOrder()
        {
            //Arrange                    
            var requestParams = _createOrderParameters;

            //Act

            Order newOrder = _foodOrderProcessor.CreateNewFoodOrder(requestParams);



            //Assert
            Assert.NotNull(newOrder);
            Assert.Equal(requestParams.Name, newOrder.Name);
            Assert.Equal(requestParams.OrderingDate, newOrder.OrderingDate);
            Assert.Equal(requestParams.OrderOwner, newOrder.Purchaser);
            Assert.Equal(requestParams.OrderOwner.FirstName + " " + requestParams.OrderOwner.LastName, newOrder.PurchaserName);
            Assert.Equal(requestParams.OrderOwner.BankAccount, newOrder.PurchaserAccountNumber);
            Assert.Equal(requestParams.Restaurant, newOrder.Restaurant);
            Assert.Equal(OrderState.New, newOrder.State);
        }

        [Fact]
        public void ShouldSaveCreatedOrder()
        {
            //Arrange                    
            var requestParams = _createOrderParameters;
                      
            //Act
            Order newOrder = _foodOrderProcessor.CreateNewFoodOrder(requestParams);

            //Assert
            _foodOrderRepositoryMock.Verify(x => x.Save(It.IsAny<Order>()), Times.Once);
      
        }

        [Fact]
        public void ShouldReturnExpectedOrderId()
        {
            //Arrange                    
            int expectedOrderId = 42;
            var requestParams = _createOrderParameters;
            _foodOrderRepositoryMock.Setup(x => x.Save(It.IsAny<Order>())).Returns(expectedOrderId);

            //Act
            Order newOrder = _foodOrderProcessor.CreateNewFoodOrder(requestParams);

            //Assert
            _foodOrderRepositoryMock.Verify(x => x.Save(It.IsAny<Order>()), Times.Once);
            Assert.Equal(newOrder.Id, expectedOrderId);
        }
      
    }
}
