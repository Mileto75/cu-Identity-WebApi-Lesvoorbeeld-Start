using Microsoft.EntityFrameworkCore.Migrations;

namespace cu.ApiBasics.Lesvoorbeeld.Avond.Infrastructure.Migrations
{
    public partial class seedingAdminAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "7c447342-050f-4d47-9159-8ce91ebbc0d2", "admin@products.com", true, "Johnny", "De Beer", false, null, "ADMIN@PRODUCTS.COM", "ADMIN@PRODUCTS.COM", "AQAAAAEAACcQAAAAEFUhd60WHp2CsYFyEi9mAFEF0WCfy+2zp7GGA7VHY/by8CNXwutgOXihxgl1qjSSqg==", null, false, "228f4dac-9630-430e-86b7-e1a30285f330", false, "admin@products.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2", 0, "d20d899c-73d6-4721-9f19-ea0d98240632", "bart@products.com", true, "Bart", "De Beer", false, null, "BART@PRODUCTS.COM", "BART@PRODUCTS.COM", "AQAAAAEAACcQAAAAEBCZ1M73sCQBrelhBkMeODKpH+L0K53WVWNNNJVs2vrKMUS6Ra7re96ttWLykaznow==", null, false, "2a721a7d-b0cd-42e6-b81f-f39bf9d140d2", false, "bart@products.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "role", "admin", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 2, "role", "customer", "2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
