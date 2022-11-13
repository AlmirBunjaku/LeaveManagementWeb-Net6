using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24dfaed2-aee3-49c8-be73-94508607c2f5",
                column: "ConcurrencyStamp",
                value: "0c606472-333c-4f09-90d7-fc1e0159fbad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7050ad9-9481-4430-bd8a-74da2a672457",
                column: "ConcurrencyStamp",
                value: "be510736-2528-462f-9bed-39a78d98494f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd4a5daf-b375-4cef-b77f-badc03669012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84c4e3bb-8da1-41e0-b2d5-db6b12672b61", "AQAAAAEAACcQAAAAEMppJN9jbyL9QgwMPGKm9mwwfR9ovbsSCGE2Ns+5kKP/7AmjnR9rFSEds2DpIUP4lA==", "fd7ed4f3-a97d-47fc-b305-2b09c5320a62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3858f5f-535a-490e-a5e8-558f58c4b4c9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41f2a1d1-478b-45e4-9cb8-3b0c0ae335fe", "AQAAAAEAACcQAAAAEEWIh+p89BVpOGzdNWFunESkY9I0Vsd0JRnZJzsf/I1W7rm1fY4lTEm3c+URImjOYA==", "267d8821-8883-471c-9293-c30060a9d0f8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestingEmployeeId",
                table: "LeaveRequests");

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
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
                value: "07c333a4-f0d5-46c6-8302-76944f62a8ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7050ad9-9481-4430-bd8a-74da2a672457",
                column: "ConcurrencyStamp",
                value: "5c8d1ebf-b040-4774-bec8-eb1088695703");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd4a5daf-b375-4cef-b77f-badc03669012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6cdcf2c-e113-48dc-96cd-6191e9f374ff", "AQAAAAEAACcQAAAAEN78d8ynU2KR9iNj5hVZjHOznos+7fwMFDAi6CG2yE8dyBuXWX3YR7pvuQ1LO6Y5jg==", "41d6ef15-b8ac-4295-aa90-6890a9740784" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3858f5f-535a-490e-a5e8-558f58c4b4c9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8831c3e-536b-4f07-bf07-2a3197205299", "AQAAAAEAACcQAAAAEPZ4T1fo56jQ3tXZRQkTY/yWKkJj6IaAKR0oybBRKCs1xWT77zUABcEZ0CgkdHZvQQ==", "8206651b-d686-4b8c-82e0-50cb8608d9a4" });
        }
    }
}
