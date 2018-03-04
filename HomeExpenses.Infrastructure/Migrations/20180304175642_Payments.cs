using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeExpenses.Infrastructure.Migrations
{
    public partial class Payments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                schema: "Expense",
                table: "Bill");

            migrationBuilder.AddColumn<Guid>(
                name: "RecipientId",
                schema: "Expense",
                table: "Bill",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Payment",
                schema: "Expense",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    BillId = table.Column<Guid>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Bill_BillId",
                        column: x => x.BillId,
                        principalSchema: "Expense",
                        principalTable: "Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipient",
                schema: "Expense",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_Community = table.Column<string>(nullable: true),
                    Address_Country = table.Column<string>(nullable: true),
                    Address_County = table.Column<string>(nullable: true),
                    Address_District = table.Column<string>(nullable: true),
                    Address_Number = table.Column<string>(nullable: true),
                    Address_Street = table.Column<string>(nullable: true),
                    Address_Voivodeship = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipient", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_RecipientId",
                schema: "Expense",
                table: "Bill",
                column: "RecipientId",
                unique: true,
                filter: "[RecipientId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_BillId",
                schema: "Expense",
                table: "Payment",
                column: "BillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Recipient_RecipientId",
                schema: "Expense",
                table: "Bill",
                column: "RecipientId",
                principalSchema: "Expense",
                principalTable: "Recipient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Recipient_RecipientId",
                schema: "Expense",
                table: "Bill");

            migrationBuilder.DropTable(
                name: "Payment",
                schema: "Expense");

            migrationBuilder.DropTable(
                name: "Recipient",
                schema: "Expense");

            migrationBuilder.DropIndex(
                name: "IX_Bill_RecipientId",
                schema: "Expense",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "RecipientId",
                schema: "Expense",
                table: "Bill");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                schema: "Expense",
                table: "Bill",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
