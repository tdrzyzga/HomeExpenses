﻿// <auto-generated />
using HomeExpenses.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HomeExpenses.Infrastructure.Migrations
{
    [DbContext(typeof(HomeExpensesDbContext))]
    [Migration("20180304175642_Payments")]
    partial class Payments
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeExpenses.Domain.Bill.Model.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<Guid>("CreatorId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<Guid?>("RecipientId");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId")
                        .IsUnique()
                        .HasFilter("[RecipientId] IS NOT NULL");

                    b.ToTable("Bill","Expense");
                });

            modelBuilder.Entity("HomeExpenses.Domain.Bill.Model.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<Guid?>("BillId");

                    b.Property<DateTime>("DateTime");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.ToTable("Payment","Expense");
                });

            modelBuilder.Entity("HomeExpenses.Domain.Bill.Model.Recipient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Recipient","Expense");
                });

            modelBuilder.Entity("HomeExpenses.Domain.Bill.Model.Bill", b =>
                {
                    b.HasOne("HomeExpenses.Domain.Bill.Model.Recipient", "Recipient")
                        .WithOne()
                        .HasForeignKey("HomeExpenses.Domain.Bill.Model.Bill", "RecipientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HomeExpenses.Domain.Bill.Model.Payment", b =>
                {
                    b.HasOne("HomeExpenses.Domain.Bill.Model.Bill")
                        .WithMany("Payments")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HomeExpenses.Domain.Bill.Model.Recipient", b =>
                {
                    b.OwnsOne("Core.Domain.ValueObjects.AddressValueObject", "Address", b1 =>
                        {
                            b1.Property<Guid>("RecipientId");

                            b1.Property<string>("City");

                            b1.Property<string>("Community");

                            b1.Property<string>("Country");

                            b1.Property<string>("County");

                            b1.Property<string>("District");

                            b1.Property<string>("Number");

                            b1.Property<string>("Street");

                            b1.Property<string>("Voivodeship");

                            b1.ToTable("Recipient","Expense");

                            b1.HasOne("HomeExpenses.Domain.Bill.Model.Recipient")
                                .WithOne("Address")
                                .HasForeignKey("Core.Domain.ValueObjects.AddressValueObject", "RecipientId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
