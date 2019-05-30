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
            SendOrder _sendOrder = new SendDairyFreeOrder();
            _sendOrder._restaurant = new DinerOrders();
            results.Add(_sendOrder.Send());

            _sendOrder._restaurant = new FancyRestaurantOrders();
            results.Add(_sendOrder.Send());

            _sendOrder = new SendGlutenFreeOrder();
            _sendOrder._restaurant = new DinerOrders();
            results.Add(_sendOrder.Send());

            _sendOrder._restaurant = new FancyRestaurantOrders();
            results.Add(_sendOrder.Send());

            // Assert
            Assert.Equal("Placing order for Dairy-Free Order at the Diner.", results[0]);
            Assert.Equal("Placing order for Dairy-Free Order at the Fancy Restaurant.", results[1]);
            Assert.Equal("Placing order for Gluten-Free Order at the Diner.", results[2]);
            Assert.Equal("Placing order for Gluten-Free Order at the Fancy Restaurant.", results[3]);
        }
    }
}