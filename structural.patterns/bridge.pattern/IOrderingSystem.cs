namespace bridge.pattern
{
    /// <summary>
    /// Implementor which defines an interface for placing an order
    /// </summary>
    public interface IOrderingSystem
    {
        string Place(string order);
    }
}