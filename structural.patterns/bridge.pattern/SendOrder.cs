namespace bridge.pattern
{
    /// <summary>
    /// Abstraction which represent the sent order and maintains a reference to the restaurant where the order is going
    /// </summary>
    public abstract class SendOrder
    {
        // Reference to the implementor
        public IOrderingSystem Restaurant;

        public abstract string Send();
    }
}