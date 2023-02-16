using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppSklepZoologiczny.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68bdf9cb-4866-444d-8cf5-56d54170dc81",
                column: "Name",
                value: "ADMIN");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d666d3-40ed-4e9d-bc18-e56f2b69dceb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14cc8132-d74c-46bc-9e62-7fbb0567ffec", "AQAAAAEAACcQAAAAED2vdVijIUAOaeQ2HwI/woxyWGSWtusdBZybI8rgbLyDGtVwKAoqQO9RYG1usk13Ag==", "11dedf64-e4de-4add-a938-9003dc04f68c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68bdf9cb-4866-444d-8cf5-56d54170dc81",
                column: "Name",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d666d3-40ed-4e9d-bc18-e56f2b69dceb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78cf7fe7-2ae9-4929-b8cb-df50c6f4f891", "AQAAAAEAACcQAAAAEDcwTltGufW3fwXkrA7+7KOFJZW9/lfm5tb9v41SJeOKzwxG2aj5/D4oSZ9qFpWVQA==", "32b53dc3-3553-4305-91d6-e1c0f081f5f4" });
        }
    }
}
