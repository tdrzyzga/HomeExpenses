using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeExpenses.Infrastructure.Migrations
{
    public partial class ExpenseTypev5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExpenseTypeBase_ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase");

            migrationBuilder.AlterColumn<Guid>(
                name: "ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTypeBase_ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                column: "ExpenseId",
                unique: true,
                filter: "[ExpenseId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExpenseTypeBase_ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase");

            migrationBuilder.AlterColumn<Guid>(
                name: "ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTypeBase_ExpenseId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                column: "ExpenseId",
                unique: true);
        }
    }
}
