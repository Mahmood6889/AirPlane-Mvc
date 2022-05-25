using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirPlane_Mvc.Migrations
{
    public partial class Airplane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarikh_Tasis = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Flies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mabda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maghsad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parvaz = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mablagh = table.Column<int>(type: "int", nullable: false),
                    Tedad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Flies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Companies");

            migrationBuilder.DropTable(
                name: "tbl_Flies");
        }
    }
}
