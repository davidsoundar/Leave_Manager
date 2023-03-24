using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dfe8eacd-e07a-4621-a452-7b5d7cae8433", null, "Administrator", "ADMINISTRATOR" },
                    { "dfe9eacd-e08a-4621-a546-7b5d7cae8433", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1b22d292-ab06-47a0-9528-f54e8d3075ea", 0, "48707584-df86-4c8f-b1b8-3e065f0820cb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIdHPMv/TBgzfvqt7jlHzLHvDZv8D0yh2GPUcTv1d7DYfKadyrnN0BN1dxlj6o0mFg==", null, false, "c5d9549f-795d-4502-b5dc-8f8e3193e833", null, false, "user@localhost.com" },
                    { "ab0c6b3d-adde-4553-94b6-2aa4e3eb85b2", 0, "b3b5fae1-dec2-4312-a3c2-45b388228bb6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEwM2VG0rljkzYblLrtmNHkYfG4GdRrZdFMbzzKVNjbHfxJrERYIG8Tx2yDWf4wQ+A==", null, false, "3b6eb83e-b721-4b72-8ee6-795be82743b3", null, false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dfe9eacd-e08a-4621-a546-7b5d7cae8433", "1b22d292-ab06-47a0-9528-f54e8d3075ea" },
                    { "dfe8eacd-e07a-4621-a452-7b5d7cae8433", "ab0c6b3d-adde-4553-94b6-2aa4e3eb85b2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dfe9eacd-e08a-4621-a546-7b5d7cae8433", "1b22d292-ab06-47a0-9528-f54e8d3075ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dfe8eacd-e07a-4621-a452-7b5d7cae8433", "ab0c6b3d-adde-4553-94b6-2aa4e3eb85b2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfe8eacd-e07a-4621-a452-7b5d7cae8433");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfe9eacd-e08a-4621-a546-7b5d7cae8433");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b22d292-ab06-47a0-9528-f54e8d3075ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab0c6b3d-adde-4553-94b6-2aa4e3eb85b2");
        }
    }
}
