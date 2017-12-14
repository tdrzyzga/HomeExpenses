using HomeExpenses.Domain.Bill;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

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
        }
    }

    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable(nameof(Bill), HomeExpensesDbContext.Schema);
        }
    }
}
