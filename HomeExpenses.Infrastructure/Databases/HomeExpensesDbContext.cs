using HomeExpenses.Domain.Expenses.Model;
using HomeExpenses.Domain.Expenses.Model.ExpenseType;
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

            modelBuilder.ApplyConfiguration(new ExpenseConfiguration());

            modelBuilder.ApplyConfiguration(new ExpenseTypeBaseConfiguration());
            modelBuilder.ApplyConfiguration(new PeriodicExpenseTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AperiodicExpenseTypeConfiguration());

            modelBuilder.ApplyConfiguration(new RecipientConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
        }
    }

    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.ExpenseType)
                   .WithOne(x => x.Expense)
                   .HasForeignKey<ExpenseTypeBase>("ExpenseId")
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Payments)
                   .WithOne()
                   .HasForeignKey("ExpenseId")
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(nameof(Expense), HomeExpensesDbContext.Schema);
        }
    }

    public class ExpenseTypeBaseConfiguration : IEntityTypeConfiguration<ExpenseTypeBase>
    {
        public void Configure(EntityTypeBuilder<ExpenseTypeBase> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable(nameof(ExpenseTypeBase), HomeExpensesDbContext.Schema);
        }
    }

    public class PeriodicExpenseTypeConfiguration : IEntityTypeConfiguration<PeriodicExpenseType>
    {
        public void Configure(EntityTypeBuilder<PeriodicExpenseType> builder)
        {
            builder.ToTable(nameof(PeriodicExpenseType), HomeExpensesDbContext.Schema);
        }
    }

    public class AperiodicExpenseTypeConfiguration : IEntityTypeConfiguration<AperiodicExpenseType>
    {
        public void Configure(EntityTypeBuilder<AperiodicExpenseType> builder)
        {
            builder.ToTable(nameof(AperiodicExpenseType), HomeExpensesDbContext.Schema);
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