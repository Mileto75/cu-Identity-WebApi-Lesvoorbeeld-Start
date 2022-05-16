using Microsoft.EntityFrameworkCore.Migrations;

namespace cu.ApiBasics.Lesvoorbeeld.Avond.Infrastructure.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/role");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimType",
                value: "http://schemas.microsoft.com/ws/2008/06/identity/claims/role");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ed71822-6937-4fe0-a5d8-9b8cdeaffccf", "AQAAAAEAACcQAAAAEIPxTAoLlM62xqoe7ew00hV689Dn9yemJn8q6OrNSWpPqAz6tx/tafteDDbTfdIidQ==", "56119ccf-245e-48a5-afe3-47b29ab60a69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4edde5f6-cb9f-47a5-aea0-517ea8b51897", "AQAAAAEAACcQAAAAEJbNG+1tSSh47+OQeWEa9iLkuwxD6FUTlJFu2yj+YRQgiOcv7YgZrBdSiS5Qfhljug==", "bd677f2f-68a8-4213-b1fc-72c4165468b3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClaimType",
                value: "role");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimType",
                value: "role");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c447342-050f-4d47-9159-8ce91ebbc0d2", "AQAAAAEAACcQAAAAEFUhd60WHp2CsYFyEi9mAFEF0WCfy+2zp7GGA7VHY/by8CNXwutgOXihxgl1qjSSqg==", "228f4dac-9630-430e-86b7-e1a30285f330" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d20d899c-73d6-4721-9f19-ea0d98240632", "AQAAAAEAACcQAAAAEBCZ1M73sCQBrelhBkMeODKpH+L0K53WVWNNNJVs2vrKMUS6Ra7re96ttWLykaznow==", "2a721a7d-b0cd-42e6-b81f-f39bf9d140d2" });
        }
    }
}
