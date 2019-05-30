namespace bridge.pattern
{
    public class SendDairyFreeOrder : SendOrder
    {
        public override string Send()
        {
            return _restaurant.Place("Dairy-Free Order");
        }
    }
}