using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeExpenses.Infrastructure.Migrations
{
    public partial class ExpenseTypeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_ExpenseTypeBase_ExpenseTypeId",
                schema: "Expenses",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Expense_BillId",
                schema: "Expenses",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Expense_ExpenseTypeId",
                schema: "Expenses",
                table: "Expense");

            migrationBuilder.DropColumn(
                name: "ExpenseTypeId",
                schema: "Expenses",
                table: "Expense");

            migrationBuilder.RenameColumn(
                name: "BillId",
                schema: "Expenses",
                table: "Payment",
                newName: "ExpenseId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_BillId",
                schema: "Expenses",
                table: "Payment",
                newName: "IX_Payment_ExpenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseTypeBase_Expense_Id",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                column: "Id",
                principalSchema: "Expenses",
                principalTable: "Expense",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Expense_ExpenseId",
                schema: "Expenses",
                table: "Payment",
                column: "ExpenseId",
                principalSchema: "Expenses",
                principalTable: "Expense",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseTypeBase_Expense_Id",
                schema: "Expenses",
                table: "ExpenseTypeBase");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Expense_ExpenseId",
                schema: "Expenses",
                table: "Payment");

            migrationBuilder.RenameColumn(
                name: "ExpenseId",
                schema: "Expenses",
                table: "Payment",
                newName: "BillId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_ExpenseId",
                schema: "Expenses",
                table: "Payment",
                newName: "IX_Payment_BillId");

            migrationBuilder.AddColumn<Guid>(
                name: "ExpenseTypeId",
                schema: "Expenses",
                table: "Expense",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Expense_ExpenseTypeId",
                schema: "Expenses",
                table: "Expense",
                column: "ExpenseTypeId",
                unique: true,
                filter: "[ExpenseTypeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_ExpenseTypeBase_ExpenseTypeId",
                schema: "Expenses",
                table: "Expense",
                column: "ExpenseTypeId",
                principalSchema: "Expenses",
                principalTable: "ExpenseTypeBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
