using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeExpenses.Infrastructure.Migrations
{
    public partial class ExpenseType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseTypeBase_Expense_Id",
                schema: "Expenses",
                table: "ExpenseTypeBase");

            migrationBuilder.AddColumn<Guid>(
                name: "ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTypeBase_ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                column: "ExpenseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseTypeBase_Expense_ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                column: "ExpenseId",
                principalSchema: "Expenses",
                principalTable: "Expense",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseTypeBase_Expense_ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseTypeBase_ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase");

            migrationBuilder.DropColumn(
                name: "ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseTypeBase_Expense_Id",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                column: "Id",
                principalSchema: "Expenses",
                principalTable: "Expense",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
