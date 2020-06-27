using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using zCzosnkowym.DataAccess.Context;
using zCzosnkowym.DataAccess.Entities;

namespace zCzosnkowym.DataAccess
{
    public class RestaurantRepositoryTest
    {
        [Fact]
        public async void ShouldGetAllRestaurants()
        {

            var options = new DbContextOptionsBuilder<OrderFoodContext>().UseInMemoryDatabase(databaseName: "ShouldGetAllRestaurants").Options;

            var sortedList = new List<Restaurant>()
            {
                new Restaurant() {Name = "Ramzes", Website = "www.ramzes.pl"},
                new Restaurant() {Name = "Kebab Hot", Website = "www.kebabhot.pl"},
                new Restaurant() {Name = "Muzyczna", Website = "www.muzyczna.pl"}
            };


            using (var context = new OrderFoodContext(options))
            {
                foreach (var game in sortedList)
                {
                    context.Add(game);
                    context.SaveChanges();
                }
            }

            // Act
            IEnumerable<Restaurant> actualList;
            using (var context = new OrderFoodContext(options))
            {
                var repository = new RestaurantRepository(context);
                actualList = await repository.GetAll();
            }

            // Assert
            Assert.Equal(sortedList.Count(), actualList.Count());
        }
    }
}
