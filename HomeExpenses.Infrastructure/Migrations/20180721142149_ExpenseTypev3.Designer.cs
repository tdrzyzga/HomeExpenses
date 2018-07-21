﻿// <auto-generated />
using System;
using HomeExpenses.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeExpenses.Infrastructure.Migrations
{
    [DbContext(typeof(HomeExpensesDbContext))]
    [Migration("20180721142149_ExpenseTypev3")]
    partial class ExpenseTypev3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeExpenses.Domain.Expenses.Model.Expense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<Guid?>("ExpenseTypeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<Guid?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("ExpenseTypeId");

                    b.ToTable("Expense","Expenses");
                });

            modelBuilder.Entity("HomeExpenses.Domain.Expenses.Model.ExpenseType.ExpenseTypeBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ExpenseTypeBase","Expenses");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ExpenseTypeBase");
                });

            modelBuilder.Entity("HomeExpenses.Domain.Expenses.Model.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("DateTime");

                    b.Property<Guid?>("ExpenseId");

                    b.Property<Guid?>("RecipientId");

                    b.HasKey("Id");

                    b.HasIndex("ExpenseId");

                    b.ToTable("Payment","Expenses");
                });

            modelBuilder.Entity("HomeExpenses.Domain.Recipients.Model.Recipient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<Guid?>("TenantId");

                    b.HasKey("Id");

                    b.ToTable("Recipient","Expenses");
                });

            modelBuilder.Entity("HomeExpenses.Domain.Expenses.Model.ExpenseType.AperiodicExpenseType", b =>
                {
                    b.HasBaseType("HomeExpenses.Domain.Expenses.Model.ExpenseType.ExpenseTypeBase");

                    b.Property<string>("Description");

                    b.ToTable("AperiodicExpenseType","Expenses");

                    b.HasDiscriminator().HasValue("AperiodicExpenseType");
                });

            modelBuilder.Entity("HomeExpenses.Domain.Expenses.Model.ExpenseType.PeriodicExpenseType", b =>
                {
                    b.HasBaseType("HomeExpenses.Domain.Expenses.Model.ExpenseType.ExpenseTypeBase");

                    b.Property<int>("DayOfMonth");

                    b.Property<int>("MonthInterval");

                    b.ToTable("PeriodicExpenseType","Expenses");

                    b.HasDiscriminator().HasValue("PeriodicExpenseType");
                });

            modelBuilder.Entity("HomeExpenses.Domain.Expenses.Model.Expense", b =>
                {
                    b.HasOne("HomeExpenses.Domain.Expenses.Model.ExpenseType.ExpenseTypeBase", "ExpenseType")
                        .WithMany()
                        .HasForeignKey("ExpenseTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HomeExpenses.Domain.Expenses.Model.Payment", b =>
                {
                    b.HasOne("HomeExpenses.Domain.Expenses.Model.Expense")
                        .WithMany("Payments")
                        .HasForeignKey("ExpenseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HomeExpenses.Domain.Recipients.Model.Recipient", b =>
                {
                    b.OwnsOne("Core.Domain.ValueObjects.AddressValueObject", "Address", b1 =>
                        {
                            b1.Property<Guid?>("RecipientId");

                            b1.Property<string>("City");

                            b1.Property<string>("Community");

                            b1.Property<string>("Country");

                            b1.Property<string>("County");

                            b1.Property<string>("District");

                            b1.Property<string>("Number");

                            b1.Property<string>("Street");

                            b1.Property<string>("Voivodeship");

                            b1.ToTable("Recipient","Expenses");

                            b1.HasOne("HomeExpenses.Domain.Recipients.Model.Recipient")
                                .WithOne("Address")
                                .HasForeignKey("Core.Domain.ValueObjects.AddressValueObject", "RecipientId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
