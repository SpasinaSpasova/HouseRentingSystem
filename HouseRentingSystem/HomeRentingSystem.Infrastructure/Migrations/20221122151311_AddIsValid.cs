using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeRentingSystem.Infrastructure.Migrations
{
    public partial class AddIsValid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c941dd97-7240-4dce-beae-dd4702ed36cc", "AQAAAAEAACcQAAAAEIn0mIDOUjXsrUECBB006VWA1Efc+Q/n65m66RjuOGup4uiyAoOZaYBcIuioqpx3Ig==", "ef63564d-325c-48e6-91a0-5e8839e697be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b016755c-ded8-414a-ba49-236c37e36918", "AQAAAAEAACcQAAAAEFJsLo2AOfTVVZKOZgY3cab0Vb7DZFkweAEaPBLgExpB+xZuD5Mg2AE0IATqaAQKkA==", "3f8bbcea-b875-4efa-841e-e454315d6502" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Houses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d718254-f953-4fb8-a8a1-97fb42bc3a44", "AQAAAAEAACcQAAAAEMxuJDJYyVftGHQ8SWEFVGP/YISwfGcF7r9BDx8wxPGDAB4oGbgar+/1nZuJrSgR5Q==", "7adf79a2-3ceb-4a21-b38d-b708460131ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e047ce2-a5c8-425f-abce-3ed05e2bddb2", "AQAAAAEAACcQAAAAEPmvfJyNTg66SPCOZFIoRXgPq83iONO6D/gRFyS+J9MfNUEI9v+HQOzCJbhwwesaNg==", "ac1bbc1b-6703-46f6-81a8-11ea69b7eca6" });
        }
    }
}
