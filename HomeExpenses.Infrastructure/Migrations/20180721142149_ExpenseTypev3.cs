using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeExpenses.Infrastructure.Migrations
{
    public partial class ExpenseTypev3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "ExpenseTypeId",
                schema: "Expenses",
                table: "Expense",
                nullable: true,
                oldClrType: typeof(Guid));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ExpenseTypeId",
                schema: "Expenses",
                table: "Expense",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTypeBase_ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                column: "ExpenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseTypeBase_Expense_ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                column: "ExpenseId",
                principalSchema: "Expenses",
                principalTable: "Expense",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
