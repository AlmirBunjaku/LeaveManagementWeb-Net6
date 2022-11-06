using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class ChangedAllocationEmployeeIdType2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24dfaed2-aee3-49c8-be73-94508607c2f5",
                column: "ConcurrencyStamp",
                value: "f2bc907d-ddfd-4b6b-a538-3330d231005c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7050ad9-9481-4430-bd8a-74da2a672457",
                column: "ConcurrencyStamp",
                value: "4f3c3956-f3a1-4c2c-a897-2623c86114d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd4a5daf-b375-4cef-b77f-badc03669012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78dcbb8f-459e-452d-b3c7-42ac233e2f4e", "AQAAAAEAACcQAAAAELn5vPXkI/s8NKY48ZP4saS4sFl4u6X7kBRP+qzbEqSmV1Wk/QUAczFh/a0/e0Qfxw==", "dd208322-33a7-4a87-993b-232980922a32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3858f5f-535a-490e-a5e8-558f58c4b4c9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f6971ba-9eb0-4775-9d71-5fa258676c4b", "AQAAAAEAACcQAAAAED+iT67KKQ7+dvG6GOwHNTHq/CFVM2wBYKce7uGXkpd7pre8H6/YcrlsPifzuz+N6A==", "4e1db85c-e188-4d31-bdc9-2508f5e898fb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24dfaed2-aee3-49c8-be73-94508607c2f5",
                column: "ConcurrencyStamp",
                value: "7e6d6068-48c6-44c5-86a7-f030b662a35a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7050ad9-9481-4430-bd8a-74da2a672457",
                column: "ConcurrencyStamp",
                value: "4550f881-35d8-4d70-bb94-ac9f3686e5ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd4a5daf-b375-4cef-b77f-badc03669012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3e4538a-8904-4733-b332-7ce1873b922d", "AQAAAAEAACcQAAAAEKXA9fALQpHInEszsNVrCUytd5NA0zXiOHr0iE8lbCOXWf5899exmlu0AmyCSr1Isg==", "659178d8-01ab-4397-b080-fcf7259fb5e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3858f5f-535a-490e-a5e8-558f58c4b4c9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04af9d33-4d56-4885-b9f9-052f3332b31a", "AQAAAAEAACcQAAAAEGgb4QIKMRpBALdGkaSb7axB59kSfhvsWtZS12WgC7CcEFhZ8iraAlcYNzj2GatbWw==", "da1416fd-d39c-4188-afc4-b7ff5de35cd0" });
        }
    }
}
