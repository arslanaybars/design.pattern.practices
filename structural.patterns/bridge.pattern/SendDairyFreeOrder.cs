namespace bridge.pattern
{
    public class SendDairyFreeOrder : SendOrder
    {
        public override string Send()
        {
            return Restaurant.Place("Dairy-Free Order");
        }
    }
}