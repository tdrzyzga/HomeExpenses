using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeExpenses.Infrastructure.Migrations
{
    public partial class RecipientAggregate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseTypeBase_Recipient_RecipientId",
                schema: "Expenses",
                table: "ExpenseTypeBase");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseTypeBase_RecipientId",
                schema: "Expenses",
                table: "ExpenseTypeBase");

            migrationBuilder.DropColumn(
                name: "RecipientId",
                schema: "Expenses",
                table: "ExpenseTypeBase");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "Expenses",
                table: "Recipient",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Expenses",
                table: "Recipient",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                schema: "Expenses",
                table: "Recipient",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RecipientId",
                schema: "Expenses",
                table: "Payment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "Expenses",
                table: "Recipient");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Expenses",
                table: "Recipient");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                schema: "Expenses",
                table: "Recipient");

            migrationBuilder.DropColumn(
                name: "RecipientId",
                schema: "Expenses",
                table: "Payment");

            migrationBuilder.AddColumn<Guid>(
                name: "RecipientId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTypeBase_RecipientId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                column: "RecipientId",
                unique: true,
                filter: "[RecipientId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseTypeBase_Recipient_RecipientId",
                schema: "Expenses",
                table: "ExpenseTypeBase",
                column: "RecipientId",
                principalSchema: "Expenses",
                principalTable: "Recipient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
