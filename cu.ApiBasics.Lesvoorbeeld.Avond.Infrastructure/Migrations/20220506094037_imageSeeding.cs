using Microsoft.EntityFrameworkCore.Migrations;

namespace cu.ApiBasics.Lesvoorbeeld.Avond.Infrastructure.Migrations
{
    public partial class imageSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "276a1a8a-cb71-48ba-aec5-18ad2b18272f", "AQAAAAEAACcQAAAAEMDXa9x66DIUAODuPmyCMBep2KF9Pk7SAQQgyOhJkY9VocooqX5hho4z6H4jC2B8BQ==", "7e61de9f-2599-4165-9d3f-0cf0e591c048" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c84d3200-07d0-4084-a77e-4f1ace971b7e", "AQAAAAEAACcQAAAAEA7Q7mkvzWLOnQF20sOrIT+TMtQjKmrlTXpaUzr6wqQpwwssHPhVsrh6/d+G7BwqGA==", "06cd582d-16b1-4a36-989a-1ff76a41b429" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "phone.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "phone.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "laptop.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "laptop.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "laptop.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Image", "Name" },
                values: new object[] { "tablet.jpg", "Ipad12" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Image", "Name" },
                values: new object[] { null, "Iphone12" });
        }
    }
}
