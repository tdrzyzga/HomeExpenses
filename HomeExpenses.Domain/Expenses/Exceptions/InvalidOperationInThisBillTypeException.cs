using Core.Domain.Exceptions;

namespace HomeExpenses.Domain.Bills.Exceptions
{
    public class InvalidOperationInThisBillTypeException : DomainException
    {
        public InvalidOperationInThisBillTypeException()
            : base("Cannot enter a period for a one-off bill")
        {
        }
    }
}