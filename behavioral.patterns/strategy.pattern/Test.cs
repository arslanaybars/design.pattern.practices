using System;
using System.Collections.Generic;
using Xunit;

namespace strategy.pattern
{
    public class Test
    {
        [Fact]
        public void When_shipping_via_UPS_The_shipping_cost_is_425()
        {
            var strategy = new UpsShippingCostStrategy();
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = TestInit.CreateOrder_UPS();
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            Assert.Equal(4.25d, cost);
        }

        [Fact]
        public void When_shipping_via_USPS_The_shipping_cost_is_300()
        {
            var strategy = new UspsShippingCostStrategy();
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = TestInit.CreateOrder_USPS();
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            Assert.Equal(3.00d, cost);
        }

        [Fact]
        public void When_shipping_via_FedEx_The_shipping_cost_is_5()
        {
            var strategy = new FedExShippingCostStrategy();
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = TestInit.CreateOrder_FedEx();
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            Assert.Equal(5.00d, cost);
        }

    }
}