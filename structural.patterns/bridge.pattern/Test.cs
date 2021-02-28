using System.Collections.Generic;
using Xunit;

namespace bridge.pattern
{
    public class Test
    {
        [Fact]
        public void BridgeTest()
        {
            // Arrange
            List<string> results = new List<string>();

            // Act
            SendOrder sendOrder = new SendDairyFreeOrder();

            sendOrder.Restaurant = new DinerOrders();
            results.Add(sendOrder.Send());

            sendOrder.Restaurant = new FancyRestaurantOrders();
            results.Add(sendOrder.Send());

            sendOrder = new SendGlutenFreeOrder {Restaurant = new DinerOrders()};
            results.Add(sendOrder.Send());

            sendOrder.Restaurant = new FancyRestaurantOrders();
            results.Add(sendOrder.Send());

            // Assert
            Assert.Equal("Placing order for Dairy-Free Order at the Diner.", results[0]);
            Assert.Equal("Placing order for Dairy-Free Order at the Fancy Restaurant.", results[1]);
            Assert.Equal("Placing order for Gluten-Free Order at the Diner.", results[2]);
            Assert.Equal("Placing order for Gluten-Free Order at the Fancy Restaurant.", results[3]);
        }
    }
}