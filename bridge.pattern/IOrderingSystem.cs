namespace bridge.pattern
{
    /// <summary>
    /// Implementor which efines an interface for placing an order
    /// </summary>
    public interface IOrderingSystem
    {
        string Place(string order);
    }
}