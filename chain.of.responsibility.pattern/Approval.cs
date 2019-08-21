using System;

namespace chain.of.responsibility.pattern
{
    public class Approval
    {
        public ApprovalResponse ApproveExpense(decimal expenseReportAmount)
        {
            ExpenseHandler william = new ExpenseHandler(new Employee("William Worker", Decimal.Zero));
            ExpenseHandler mary = new ExpenseHandler(new Employee("Mary Manager", new Decimal(1000)));
            ExpenseHandler victor = new ExpenseHandler(new Employee("Victor Vicepres", new Decimal(5000)));
            ExpenseHandler paula = new ExpenseHandler(new Employee("Paula President", new Decimal(20000)));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);

            IExpenseReport expense = new ExpenseReport(expenseReportAmount);

            ApprovalResponse response = william.Approve(expense);

            return response;
        }
    }
}
