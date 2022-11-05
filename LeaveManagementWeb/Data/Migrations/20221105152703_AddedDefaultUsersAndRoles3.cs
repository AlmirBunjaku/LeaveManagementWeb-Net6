using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24dfaed2-aee3-49c8-be73-94508607c2f5",
                column: "ConcurrencyStamp",
                value: "72482f99-aa33-4c5d-b605-4a085e48a428");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7050ad9-9481-4430-bd8a-74da2a672457",
                column: "ConcurrencyStamp",
                value: "f023236b-15db-4fb6-9eb8-5362b3c5d975");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd4a5daf-b375-4cef-b77f-badc03669012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1f250b7-b799-4fd8-a45a-b83c70205e7c", "AQAAAAEAACcQAAAAEMP3INlTi1orNlDtbUr3KE1wG6xdJt0uKVkTFk8E7Zc2N0Bo9PFnOhM31vr4a6f9jA==", "04ca87e5-9edd-4a85-ab95-0e3a5180333c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3858f5f-535a-490e-a5e8-558f58c4b4c9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a209a7f4-77a6-4311-8428-53ce6a80045d", "AQAAAAEAACcQAAAAEHBJH+E/HBRRxe+Ar0r4mvekDyD4bomNiV+Y1nH7kKVk7czmz1TP2HxJ9yTqAk4YHQ==", "ae67e4c1-90f1-4786-9a34-7c53423ab09c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e175cb02-142e-43cc-a7da-597fb076e1f7", "AQAAAAEAACcQAAAAEDDfuwCxIP08kSMhBYSw0JqDfj6wbMj2fDQdsijrHXGyMQVQRkEkZ3hs0m5vTOfTBQ==", "2b54d64d-f345-4315-8e21-1170bec76b9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3858f5f-535a-490e-a5e8-558f58c4b4c9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20ec3156-4c06-40e3-8c39-55ef5c513146", "AQAAAAEAACcQAAAAEGhNBHYAkzEVVU326u3ud22qhfORLrgSY5gaKLz3bmkZJowxGpGONjYTbdz2/5sF2A==", "15a890f4-83ae-4773-b583-e81c00104719" });
        }
    }
}
