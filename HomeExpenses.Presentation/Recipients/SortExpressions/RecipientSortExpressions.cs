using Core.Presentation.Pagination;
using HomeExpenses.Domain.Recipients.Model;

namespace HomeExpenses.Presentation.Recipients.SortExpressions
{
    public class RecipientSortExpressions: SortExpression<Recipient>
    {
        public RecipientSortExpressions()
        {
            AddEntry(nameof(Recipient.Name), x => x.Name); 
            AddEntry(nameof(Recipient.Address.City), x => x.Address.City); 
            AddEntry(nameof(Recipient.Address.Street), x => x.Address.Street);
        }
    }
}