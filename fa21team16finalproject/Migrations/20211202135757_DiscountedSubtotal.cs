using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fa21team16finalproject.Migrations
{
    public partial class DiscountedSubtotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExtendedPrice",
                table: "Reservations",
                newName: "DiscountedSubtotal");

            migrationBuilder.CreateTable(
                name: "ReportViewModel",
                columns: table => new
                {
                    Pkey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SearchStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SearchEndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportViewModel", x => x.Pkey);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportViewModel");

            migrationBuilder.RenameColumn(
                name: "DiscountedSubtotal",
                table: "Reservations",
                newName: "ExtendedPrice");
        }
    }
}
