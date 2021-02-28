namespace bridge.pattern
{
    public class SendGlutenFreeOrder : SendOrder
    {
        public override string Send()
        {
            return Restaurant.Place("Gluten-Free Order");
        }
    }
}