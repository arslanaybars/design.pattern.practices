namespace chain.of.responsibility.pattern
{
    public interface IExpenseApprover
    {
        ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
    }

    public class Employee : IExpenseApprover
    {
        public Employee(string name, decimal approvalLimit)
        {
            Name = name;
            _approvalLimit = approvalLimit;
        }

        public string Name { get; private set; }

        public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
        {
            return expenseReport.Total > _approvalLimit
                    ? ApprovalResponse.BeyondApprovalLimit
                    : ApprovalResponse.Approved;
        }

        private readonly decimal _approvalLimit;
    }
}