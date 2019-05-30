namespace bridge.pattern
{
    public class DinerOrders : IOrderingSystem
    {
        public string Place(string order)
        {
            return "Placing order for " + order + " at the Diner.";
        }
    }
}