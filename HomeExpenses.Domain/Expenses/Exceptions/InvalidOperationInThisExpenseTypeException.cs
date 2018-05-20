using Core.Domain.Exceptions;

namespace HomeExpenses.Domain.Expenses.Exceptions
{
    public class InvalidOperationInThisExpenseTypeException : DomainException
    {
        public InvalidOperationInThisExpenseTypeException()
            : base("This operation is not allowed in this expense type")
        {
        }
    }
}