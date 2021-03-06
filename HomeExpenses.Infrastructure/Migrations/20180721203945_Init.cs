﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeExpenses.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                "Expenses");

            migrationBuilder.CreateTable(
                "Expense",
                schema: "Expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TenantId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Expense", x => x.Id); });

            migrationBuilder.CreateTable(
                "Recipient",
                schema: "Expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TenantId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Address_Country = table.Column<string>(nullable: true),
                    Address_Voivodeship = table.Column<string>(nullable: true),
                    Address_County = table.Column<string>(nullable: true),
                    Address_Community = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_District = table.Column<string>(nullable: true),
                    Address_Street = table.Column<string>(nullable: true),
                    Address_Number = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Recipient", x => x.Id); });

            migrationBuilder.CreateTable(
                "ExpenseTypeBase",
                schema: "Expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExpenseId = table.Column<Guid>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DayOfMonth = table.Column<int>(nullable: true),
                    MonthInterval = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTypeBase", x => x.Id);
                    table.ForeignKey(
                        "FK_ExpenseTypeBase_Expense_ExpenseId",
                        x => x.ExpenseId,
                        principalSchema: "Expenses",
                        principalTable: "Expense",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Payment",
                schema: "Expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RecipientId = table.Column<Guid>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    ExpenseId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        "FK_Payment_Expense_ExpenseId",
                        x => x.ExpenseId,
                        principalSchema: "Expenses",
                        principalTable: "Expense",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_ExpenseTypeBase_ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                column: "ExpenseId",
                unique: true,
                filter: "[ExpenseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                "IX_Payment_ExpenseId",
                schema: "Expenses",
                table: "Payment",
                column: "ExpenseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "ExpenseTypeBase",
                "Expenses");

            migrationBuilder.DropTable(
                "Payment",
                "Expenses");

            migrationBuilder.DropTable(
                "Recipient",
                "Expenses");

            migrationBuilder.DropTable(
                "Expense",
                "Expenses");
        }
    }
}