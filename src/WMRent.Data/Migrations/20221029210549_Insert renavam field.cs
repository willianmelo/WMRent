using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMRent.Data.Migrations
{
    public partial class Insertrenavamfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Renavam",
                table: "Cars",
                type: "longtext",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Renavam",
                table: "Cars");
        }
    }
}
