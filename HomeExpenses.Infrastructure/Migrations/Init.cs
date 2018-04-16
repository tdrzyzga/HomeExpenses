using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeExpenses.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                "Expense");

            migrationBuilder.CreateTable(
                "Bill",
                schema: "Expense",
                columns: table => new
                {
                    Id = table.Column<Guid>("uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>("decimal(18, 2)", nullable: false),
                    CreatedOn = table.Column<DateTime>("datetime2", nullable: false),
                    CreatorId = table.Column<Guid>("uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>("bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>("datetime2", nullable: true),
                    Name = table.Column<string>("nvarchar(max)", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Bill", x => x.Id); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Bill",
                "Expense");
        }
    }
}