using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
    }
}
