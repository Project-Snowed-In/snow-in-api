using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnowedIn.Domain.Catalog;

namespace SnowedIn.Domain.Tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void Can_Create_New_Item()
        {
            // Arrange
            var item = new Item("Shirt", "A nice shirt", "Nike", 10.00m);

            // Assert
            Assert.AreEqual("Shirt", item.Name);
            Assert.AreEqual("A nice shirt", item.Description);
            Assert.AreEqual("Nike", item.Brand);
            Assert.AreEqual(10.00m, item.Price);
            Assert.AreEqual(0, item.Ratings.Count);
        }
    }
}
