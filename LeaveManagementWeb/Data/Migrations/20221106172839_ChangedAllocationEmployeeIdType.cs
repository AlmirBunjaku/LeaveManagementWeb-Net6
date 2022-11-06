using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class ChangedAllocationEmployeeIdType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24dfaed2-aee3-49c8-be73-94508607c2f5",
                column: "ConcurrencyStamp",
                value: "b05ce2ac-032b-411a-b53a-b652f6713091");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7050ad9-9481-4430-bd8a-74da2a672457",
                column: "ConcurrencyStamp",
                value: "ebbc92ac-0e33-4e7d-bab9-9a3692b80d6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd4a5daf-b375-4cef-b77f-badc03669012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfdfc4e1-1b49-41ef-baf4-13b70fa47abe", "AQAAAAEAACcQAAAAEML98ZcAngSITjyQuRBO4YTHi+/z/GrlFzFntT3jkS3SfcQpTDhA3V9gO6Bp8sP8Gw==", "8de6412f-3783-4cd7-9126-b5dc34ff853e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3858f5f-535a-490e-a5e8-558f58c4b4c9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c7a37d3-3297-4008-b69b-fd5b6850f0a9", "AQAAAAEAACcQAAAAEMowjzOtEhLv1VUSwNw4a8VzmhUH0nSAUU0Gzz7PL8LWGMN5T5ayjRWgRcPxtGrzfg==", "7ae62ed5-6d66-4f4c-858f-239305689cb7" });
        }
    }
}
