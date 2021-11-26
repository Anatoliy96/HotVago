using Microsoft.EntityFrameworkCore.Migrations;

namespace HotVago.Migrations
{
    public partial class chanageproprtyforeingkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropertyID",
                table: "PropertyTypes");

            migrationBuilder.AddColumn<int>(
                name: "PropertyTypeID",
                table: "Property",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropertyTypeID",
                table: "Property");

            migrationBuilder.AddColumn<int>(
                name: "PropertyID",
                table: "PropertyTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
