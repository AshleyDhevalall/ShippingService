using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using ShippingService.Controllers;

namespace ShippingService.Tests
{
    public class ShippingControllerTests
    {
        [Test]
        public void Ship_Given_Valid_ShippingModel_Should_Pass()
        {
            // Arrange
            var model = new ShippingModel { Address = "Asia" };
            var mock = new Mock<ILogger<ShippingController>>();
            ILogger<ShippingController> logger = mock.Object;

            var controller = new ShippingController(logger);

            // Act
            var result = controller.Ship(model);

            var okResult = result as Microsoft.AspNetCore.Mvc.OkResult;

            // Assert
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }
    }
}