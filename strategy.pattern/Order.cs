namespace strategy.pattern
{
    public class Order
    {
        public enum ShippingOptions
        {
            UPS = 100,
            FedEx = 200,
            USPS = 300,
        };

        public ShippingOptions ShippingMethod { get; set; }
        
        public Address Destination { get; set; }
        
        public Address Origin { get; set; }
    }
}