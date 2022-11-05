using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24dfaed2-aee3-49c8-be73-94508607c2f5",
                column: "ConcurrencyStamp",
                value: "aababd20-baf0-4473-8a37-959b070cf03e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7050ad9-9481-4430-bd8a-74da2a672457",
                column: "ConcurrencyStamp",
                value: "3dd133c3-4243-4a67-a30a-eb718a8d5381");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd4a5daf-b375-4cef-b77f-badc03669012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b95c494b-059d-4aff-ab42-363b2398b85e", "AQAAAAEAACcQAAAAEC1EYXKHDMU8fN1MT4jwxYM4oyCXl+xzQ7X6vLkrASp+SzGYTCHtgYoLK7Vu99MRkw==", "4dd2337e-b86e-44d8-8e66-1e1cbeb65892" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3858f5f-535a-490e-a5e8-558f58c4b4c9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cfdce5d-6062-49c0-b58f-1220368207dd", "AQAAAAEAACcQAAAAEPlOEPKNsY1yapfuQrS7Ph+ViVbJw7lKTrUh1BsL1XopG1SsIG6CTxXnyZmCo9ABqw==", "bcb1e7d3-6f64-4a34-b98f-ec1b58b424a2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
