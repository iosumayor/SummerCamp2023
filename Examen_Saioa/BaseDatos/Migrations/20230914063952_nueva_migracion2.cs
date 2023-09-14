using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseDatos.Migrations
{
    public partial class nueva_migracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persona",
                columns: new[] { "Id", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", "987654321" },
                    { 2, new DateTime(1985, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maria", "123456789" },
                    { 3, new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro", "555555555" },
                    { 4, new DateTime(1982, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luisa", "777777777" },
                    { 5, new DateTime(1995, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "999999999" },
                    { 6, new DateTime(1998, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", "111111111" },
                    { 7, new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diego", "222222222" },
                    { 8, new DateTime(1996, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "333333333" },
                    { 9, new DateTime(1987, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sergio", "444444444" },
                    { 10, new DateTime(2002, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elena", "666666666" },
                    { 11, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ricardo", "888888888" },
                    { 12, new DateTime(1997, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel", "666666666" },
                    { 13, new DateTime(1989, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto", "222222222" },
                    { 14, new DateTime(2001, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalia", "111111111" },
                    { 15, new DateTime(1983, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andres", "444444444" },
                    { 16, new DateTime(1994, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carmen", "555555555" },
                    { 17, new DateTime(1999, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel", "777777777" },
                    { 18, new DateTime(2003, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beatriz", "123456789" },
                    { 19, new DateTime(1986, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alejandro", "987654321" },
                    { 20, new DateTime(1991, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silvia", "999999999" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
