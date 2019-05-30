namespace bridge.pattern
{
    public class SendGlutenFreeOrder : SendOrder
    {
        public override string Send()
        {
            return _restaurant.Place("Gluten-Free Order");
        }
    }
}