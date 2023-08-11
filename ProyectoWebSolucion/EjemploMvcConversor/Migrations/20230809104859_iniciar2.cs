using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EjemploMvcConversor.Migrations
{
    public partial class iniciar2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Capital",
                table: "Paises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capital",
                table: "Paises");
        }
    }
}
