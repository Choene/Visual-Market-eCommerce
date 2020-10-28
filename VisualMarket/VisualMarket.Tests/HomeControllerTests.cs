using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using VisualMarket.Controllers;
using VisualMarket.Models;
using VisualMarket.VisualMarket.Models;
using Xunit;

namespace VisualMarket.VisualMarket.Tests
{
    public class HomeControllerTests
    {
        public void Can_Use_Repository(){
            // Arrange
            Mock<IVisualMarketRepository> mock = new Mock<IVisualMarketRepository>();
            mock.Setup(m => m.Products).Returns((new Product[]{
                new Product {ProductID = 1, Name = "P1"},
                new Product {ProductID = 2, Name = "P2"}
            }).AsQueryable<Product>());

            HomeController controller = new HomeController(mock.Object);

            // Act
            IEnumerable<Product> result = (controller.Index() as ViewResult).ViewData.Model as IEnumerable<Product>;

            // Assert
            Product[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P1", prodArray[0].Name);
            Assert.Equal("P2", prodArray[1].Name);
        }
    }
}