namespace bridge.pattern
{
    public class FancyRestaurantOrders : IOrderingSystem
    {
        public string Place(string order)
        {
            return "Placing order for " + order + " at the Fancy Restaurant.";
        }
    }
}