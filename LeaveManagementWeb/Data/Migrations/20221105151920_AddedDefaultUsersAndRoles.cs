using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24dfaed2-aee3-49c8-be73-94508607c2f5", "e0a42b55-6add-49f3-a0d2-dd99f5346733", "User", "USER" },
                    { "c7050ad9-9481-4430-bd8a-74da2a672457", "0e38be21-1446-4305-8332-3ec453bc91c2", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bd4a5daf-b375-4cef-b77f-badc03669012", 0, "ae1671b9-a4d9-4651-adc3-3d0a3db00442", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAENSRt+n4Qy1v/GUUY38xR2vrOZLSGr6Xj8TUBrgvbmGeqF9nBXXYtUj0CnjJDpssNQ==", null, false, "cc63e9e5-57d2-4ea5-8084-18960758c83c", null, false, null },
                    { "c3858f5f-535a-490e-a5e8-558f58c4b4c9", 0, "7e3a4064-cd19-4aa4-818d-8548f7968784", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEC8jna2XUkFahDtnRW9UF6LnGwaLI03uPIn1jFXK9YyXPC9s2YQEcBdvSFqN6317uA==", null, false, "14790425-48c2-43aa-a6cb-9010e6a4f23e", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c7050ad9-9481-4430-bd8a-74da2a672457", "bd4a5daf-b375-4cef-b77f-badc03669012" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "24dfaed2-aee3-49c8-be73-94508607c2f5", "c3858f5f-535a-490e-a5e8-558f58c4b4c9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7050ad9-9481-4430-bd8a-74da2a672457", "bd4a5daf-b375-4cef-b77f-badc03669012" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "24dfaed2-aee3-49c8-be73-94508607c2f5", "c3858f5f-535a-490e-a5e8-558f58c4b4c9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24dfaed2-aee3-49c8-be73-94508607c2f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7050ad9-9481-4430-bd8a-74da2a672457");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd4a5daf-b375-4cef-b77f-badc03669012");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3858f5f-535a-490e-a5e8-558f58c4b4c9");
        }
    }
}
