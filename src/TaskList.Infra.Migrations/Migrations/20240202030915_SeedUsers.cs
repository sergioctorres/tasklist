using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskList.Infra.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "UpdatedAt", "IsActive", "Name" },
                values: new object[] { 1, DateTimeOffset.UtcNow, null, true, "NomeUsuario1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "UpdatedAt", "IsActive", "Name" },
                values: new object[] { 2, DateTimeOffset.UtcNow, null, true, "NomeUsuario2" });
        }

        /// <inheritdoc />
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
        }
    }
}
