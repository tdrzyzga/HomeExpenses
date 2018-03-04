using HomeExpenses.Domain.Bill.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeExpenses.Infrastructure.Database
{
    public class HomeExpensesDbContext : DbContext
    {
        public const string Schema = "Expense";

        public HomeExpensesDbContext(DbContextOptions<HomeExpensesDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BillConfiguration());
            modelBuilder.ApplyConfiguration(new RecipientConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
        }
    }

    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Recipient)
                   .WithOne()
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Payments)
                   .WithOne()
                   .HasForeignKey("BillId")
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(nameof(Bill), HomeExpensesDbContext.Schema);
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