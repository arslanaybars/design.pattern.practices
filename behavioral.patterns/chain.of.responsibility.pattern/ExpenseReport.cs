namespace chain.of.responsibility.pattern
{
    public interface IExpenseReport
    {
        decimal Total { get; }
    }

    public class ExpenseReport : IExpenseReport
    {
        public ExpenseReport(decimal total)
        {
            Total = total;
        }

        public decimal Total 
        { 
            get;
            private set;
        }
    }
}