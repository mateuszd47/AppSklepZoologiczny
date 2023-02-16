using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppSklepZoologiczny.Migrations
{
    /// <inheritdoc />
    public partial class newModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d666d3-40ed-4e9d-bc18-e56f2b69dceb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ed3fbf3-1537-447a-b0e2-466cfd2dfeb7", "AQAAAAEAACcQAAAAEII4Y24OLqdaHtHIPnOPajj58GSiiKUd7/jhqPsR8DstVKsdOiTA3XfRv/bpIM3bmA==", "dbf6c2d7-70d1-456d-8431-6465d86b5825" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d666d3-40ed-4e9d-bc18-e56f2b69dceb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9e894cc-a739-4cf7-8390-f377cbe277cd", "AQAAAAEAACcQAAAAEI/XdrQEc5wlmHQPSaXGgT1sh4JEiJjy+4940Eo+jNh2UTzMzB5MXgCpcR4ncomBgg==", "53e00ba6-5c65-4bb8-847c-c9b87a9f2ccb" });
        }
    }
}
