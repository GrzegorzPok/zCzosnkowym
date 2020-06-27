using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using zCzosnkowym.Core;

namespace zCzosnkowym.DataAccess
{
    public class RestaurantRepositoryTest
    {
        [Fact]
        public async void ShouldGetAllRestaurants()
        {

            var options = new DbContextOptionsBuilder<RestaurantContext>().UseInMemoryDatabase(databaseName: "ShouldGetAllRestaurants").Options;

            var sortedList = new List<Restaurant>()
            {
                new Restaurant() {Name = "Ramzes", Website = "www.ramzes.pl"},
                new Restaurant() {Name = "Kebab Hot", Website = "www.kebabhot.pl"},
                new Restaurant() {Name = "Muzyczna", Website = "www.muzyczna.pl"}
            };


            using (var context = new RestaurantContext(options))
            {
                foreach (var game in sortedList)
                {
                    context.Add(game);
                    context.SaveChanges();
                }
            }

            // Act
            IEnumerable<Restaurant> actualList;
            using (var context = new RestaurantContext(options))
            {
                var repository = new RestaurantRepository(context);
                actualList = await repository.GetAll();
            }

            // Assert
            Assert.Equal(sortedList.Count(), actualList.Count());
        }
    }
}
