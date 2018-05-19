using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeExpenses.Infrastructure.Migrations
{
    public partial class BillToExpense : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Bill_BillId",
                schema: "Expense",
                table: "Payment");

            migrationBuilder.DropTable(
                name: "Bill",
                schema: "Expense");

            migrationBuilder.EnsureSchema(
                name: "Expenses");

            migrationBuilder.RenameTable(
                name: "Recipient",
                schema: "Expense",
                newSchema: "Expenses");

            migrationBuilder.RenameTable(
                name: "Payment",
                schema: "Expense",
                newSchema: "Expenses");

            migrationBuilder.CreateTable(
                name: "ExpenseTypeBase",
                schema: "Expenses",
                columns: table => new
                {
                    Description = table.Column<string>(nullable: true),
                    Id = table.Column<Guid>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    DayOfMonth = table.Column<int>(nullable: true),
                    MonthInterval = table.Column<int>(nullable: true),
                    RecipientId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTypeBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseTypeBase_Recipient_RecipientId",
                        column: x => x.RecipientId,
                        principalSchema: "Expenses",
                        principalTable: "Recipient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                schema: "Expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ExpenseTypeId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TenantId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expense_ExpenseTypeBase_ExpenseTypeId",
                        column: x => x.ExpenseTypeId,
                        principalSchema: "Expenses",
                        principalTable: "ExpenseTypeBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expense_ExpenseTypeId",
                schema: "Expenses",
                table: "Expense",
                column: "ExpenseTypeId",
                unique: true,
                filter: "[ExpenseTypeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTypeBase_RecipientId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                column: "RecipientId",
                unique: true,
                filter: "[RecipientId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Expense_BillId",
                schema: "Expenses",
                table: "Payment",
                column: "BillId",
                principalSchema: "Expenses",
                principalTable: "Expense",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Expense_BillId",
                schema: "Expenses",
                table: "Payment");

            migrationBuilder.DropTable(
                name: "Expense",
                schema: "Expenses");

            migrationBuilder.DropTable(
                name: "ExpenseTypeBase",
                schema: "Expenses");

            migrationBuilder.EnsureSchema(
                name: "Expense");

            migrationBuilder.RenameTable(
                name: "Recipient",
                schema: "Expenses",
                newSchema: "Expense");

            migrationBuilder.RenameTable(
                name: "Payment",
                schema: "Expenses",
                newSchema: "Expense");

            migrationBuilder.CreateTable(
                name: "Bill",
                schema: "Expense",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DateOfPayment = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    MonthInterval = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RecipientId = table.Column<Guid>(nullable: true),
                    TenantId = table.Column<Guid>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bill_Recipient_RecipientId",
                        column: x => x.RecipientId,
                        principalSchema: "Expense",
                        principalTable: "Recipient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_RecipientId",
                schema: "Expense",
                table: "Bill",
                column: "RecipientId",
                unique: true,
                filter: "[RecipientId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Bill_BillId",
                schema: "Expense",
                table: "Payment",
                column: "BillId",
                principalSchema: "Expense",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
