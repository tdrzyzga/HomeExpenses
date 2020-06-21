using HomeExpenses.Domain.Payments.Model;
using HomeExpenses.Domain.Recipients.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeExpenses.Infrastructure.Databases
{
    public class HomeExpensesDbContext : DbContext
    {
        public const string Schema = "Expenses";

        public HomeExpensesDbContext(DbContextOptions<HomeExpensesDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RecipientConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
        }
    }

    public class RecipientConfiguration : IEntityTypeConfiguration<Recipient>
    {
        public void Configure(EntityTypeBuilder<Recipient> builder)
        {
            builder.HasKey(x => x.Id);
            builder.OwnsOne(x => x.Address);

            builder.ToTable(nameof(Recipient), HomeExpensesDbContext.Schema);
        }
    }

    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable(nameof(Payment), HomeExpensesDbContext.Schema);
        }
    }
}