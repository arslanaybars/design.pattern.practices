using System;

namespace chain.of.responsibility.pattern
{
    public class Approval
    {
        public ApprovalResponse ApproveExpense(decimal expenseReportAmount)
        {
            ExpenseHandler william = new ExpenseHandler(new Employee("William Worker", decimal.Zero));
            ExpenseHandler mary = new ExpenseHandler(new Employee("Mary Manager", 1000m));
            ExpenseHandler victor = new ExpenseHandler(new Employee("Victor Vicepres", 5000m));
            ExpenseHandler paula = new ExpenseHandler(new Employee("Paula President", 20000m));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);

            IExpenseReport expense = new ExpenseReport(expenseReportAmount);

            ApprovalResponse response = william.Approve(expense);

            return response;
        }
    }
}
