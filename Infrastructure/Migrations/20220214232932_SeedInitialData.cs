using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rols",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "ADMIN" });

            migrationBuilder.InsertData(
                table: "Rols",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "STANDAR" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "IdRol" },
                values: new object[] { 1, "User Admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "IdRol" },
                values: new object[] { 2, "User Standar", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rols",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rols",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
