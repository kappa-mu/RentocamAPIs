using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rentocam.Infra.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CameraWeight",
                table: "CameraDetails");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "CameraDetails",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "CameraDetails",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "CameraDetails");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "CameraDetails");

            migrationBuilder.AddColumn<string>(
                name: "CameraWeight",
                table: "CameraDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
