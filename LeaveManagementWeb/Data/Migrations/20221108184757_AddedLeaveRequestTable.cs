using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
