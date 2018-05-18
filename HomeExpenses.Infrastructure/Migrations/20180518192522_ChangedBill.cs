using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeExpenses.Infrastructure.Migrations
{
    public partial class ChangedBill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfPayment",
                schema: "Expense",
                table: "Bill",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonthInterval",
                schema: "Expense",
                table: "Bill",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                schema: "Expense",
                table: "Bill",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfPayment",
                schema: "Expense",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "MonthInterval",
                schema: "Expense",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "Type",
                schema: "Expense",
                table: "Bill");
        }
    }
}
