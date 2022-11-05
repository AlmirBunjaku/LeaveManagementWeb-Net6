using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24dfaed2-aee3-49c8-be73-94508607c2f5",
                column: "ConcurrencyStamp",
                value: "49d5a1f8-87d1-4c64-b590-20cceb4ca826");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7050ad9-9481-4430-bd8a-74da2a672457",
                column: "ConcurrencyStamp",
                value: "3145896c-fb46-438d-828f-e9b4b3fab4e9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd4a5daf-b375-4cef-b77f-badc03669012",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e175cb02-142e-43cc-a7da-597fb076e1f7", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDDfuwCxIP08kSMhBYSw0JqDfj6wbMj2fDQdsijrHXGyMQVQRkEkZ3hs0m5vTOfTBQ==", "2b54d64d-f345-4315-8e21-1170bec76b9c", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3858f5f-535a-490e-a5e8-558f58c4b4c9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "20ec3156-4c06-40e3-8c39-55ef5c513146", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGhNBHYAkzEVVU326u3ud22qhfORLrgSY5gaKLz3bmkZJowxGpGONjYTbdz2/5sF2A==", "15a890f4-83ae-4773-b583-e81c00104719", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24dfaed2-aee3-49c8-be73-94508607c2f5",
                column: "ConcurrencyStamp",
                value: "e0a42b55-6add-49f3-a0d2-dd99f5346733");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7050ad9-9481-4430-bd8a-74da2a672457",
                column: "ConcurrencyStamp",
                value: "0e38be21-1446-4305-8332-3ec453bc91c2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd4a5daf-b375-4cef-b77f-badc03669012",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ae1671b9-a4d9-4651-adc3-3d0a3db00442", false, null, "AQAAAAEAACcQAAAAENSRt+n4Qy1v/GUUY38xR2vrOZLSGr6Xj8TUBrgvbmGeqF9nBXXYtUj0CnjJDpssNQ==", "cc63e9e5-57d2-4ea5-8084-18960758c83c", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3858f5f-535a-490e-a5e8-558f58c4b4c9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7e3a4064-cd19-4aa4-818d-8548f7968784", false, null, "AQAAAAEAACcQAAAAEC8jna2XUkFahDtnRW9UF6LnGwaLI03uPIn1jFXK9YyXPC9s2YQEcBdvSFqN6317uA==", "14790425-48c2-43aa-a6cb-9010e6a4f23e", null });
        }
    }
}
