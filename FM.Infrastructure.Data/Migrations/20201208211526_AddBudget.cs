using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FM.Infrastructure.Data.Migrations
{
    public partial class AddBudget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Budget",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Income = table.Column<double>(nullable: false),
                    Bills = table.Column<double>(nullable: false),
                    Groceries = table.Column<double>(nullable: false),
                    Meals = table.Column<double>(nullable: false),
                    Savings = table.Column<double>(nullable: false),
                    Giving = table.Column<double>(nullable: false),
                    Living = table.Column<double>(nullable: false),
                    Emergency = table.Column<double>(nullable: false),
                    Unallocated = table.Column<double>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budget", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Budget");
        }
    }
}
