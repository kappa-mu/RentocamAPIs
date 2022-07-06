using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rentocam.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CameraDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModelName = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    CameraWeight = table.Column<string>(type: "TEXT", nullable: false),
                    YearOfManufacture = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CameraDetails");
        }
    }
}
