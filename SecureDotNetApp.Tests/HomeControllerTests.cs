using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecureDotNetApp.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void TestHomePageReturnsView()
        {
            // Arrange
            var controller = new SecureDotNetApp.Controllers.HomeController(null);

            // Act
            var result = controller.Index().Result;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
