using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_JWT.Migrations
{
    public partial class seedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16cb7d1a-9a49-486d-90db-11b75659f938", "59089fcf-d177-4ef0-9805-d8fd5b4b2c05", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f399cf1f-9f61-49a9-b885-9214199a58fc", "7f6a0841-9ae5-4c2b-97c0-262e942fab0f", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16cb7d1a-9a49-486d-90db-11b75659f938");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f399cf1f-9f61-49a9-b885-9214199a58fc");
        }
    }
}
