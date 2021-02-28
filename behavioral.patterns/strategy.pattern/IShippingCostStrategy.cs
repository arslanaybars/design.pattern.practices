namespace strategy.pattern
{
    public interface IShippingCostStrategy
    {
        double Calculate(Order order);
    }
}