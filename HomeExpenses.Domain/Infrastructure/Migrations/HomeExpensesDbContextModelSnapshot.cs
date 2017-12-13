﻿// <auto-generated />
using HomeExpenses.Domain.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HomeExpenses.Domain.Infrastructure.Migrations
{
    [DbContext(typeof(HomeExpensesDbContext))]
    partial class HomeExpensesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeExpenses.Domain.Entities.Bill.Model.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<Guid>("CreatorId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Bill","Expense");
                });
#pragma warning restore 612, 618
        }
    }
}