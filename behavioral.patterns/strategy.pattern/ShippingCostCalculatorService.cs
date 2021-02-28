namespace strategy.pattern
{
    public class ShippingCostCalculatorService
    {
        private readonly IShippingCostStrategy _shippingCostStrategy;

        public ShippingCostCalculatorService(IShippingCostStrategy shippingCostStrategy)
        {
            _shippingCostStrategy = shippingCostStrategy;
        }

        public double CalculateShippingCost(Order order)
        {
            return _shippingCostStrategy.Calculate(order);
        }
    }
}