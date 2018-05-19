using Core.Domain.Exceptions;

namespace HomeExpenses.Domain.Expenses.Exceptions
{
    public class ExpenseTypeAlreadyExistException : DomainException
    {
        public ExpenseTypeAlreadyExistException()
            : base("The expense type has already been set")
        {
        }
    }
}