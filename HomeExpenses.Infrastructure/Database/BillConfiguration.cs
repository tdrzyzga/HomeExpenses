using HomeExpenses.Domain.Bill;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeExpenses.Infrastructure.Database
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable(nameof(Bill), HomeExpensesDbContext.Schema);
        }
    }
}