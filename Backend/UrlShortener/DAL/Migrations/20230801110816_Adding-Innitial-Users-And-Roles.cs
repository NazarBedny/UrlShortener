using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddingInnitialUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("47cf14c1-6ab0-40d3-b48b-de72c8559976"), "User" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("85cd66d7-2998-4f29-8319-f9cfc08859c7"), "SuperAdmin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("aba6e585-7cef-4efa-80be-6338ded67baf"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "Surname" },
                values: new object[] { new Guid("1f08834d-02c8-49cc-b8d3-ca16b7b67459"), "alex.admin@gmail.com", "Alex", new byte[] { 75, 165, 63, 153, 5, 112, 178, 109, 78, 150, 251, 157, 126, 230, 24, 153, 88, 202, 2, 24, 218, 99, 57, 22, 220, 178, 128, 33, 213, 247, 147, 151, 6, 247, 205, 12, 111, 25, 81, 37, 122, 218, 154, 227, 11, 17, 150, 245, 138, 100, 214, 58, 153, 110, 121, 42, 41, 52, 192, 238, 183, 168, 91, 141 }, new byte[] { 151, 198, 8, 20, 185, 10, 242, 26, 23, 105, 61, 167, 214, 188, 156, 179, 216, 181, 145, 184, 157, 247, 206, 237, 242, 48, 44, 168, 89, 43, 174, 147, 113, 113, 240, 105, 217, 141, 229, 13, 99, 59, 180, 206, 39, 23, 3, 137, 163, 152, 58, 76, 93, 248, 91, 150, 84, 213, 81, 160, 230, 194, 210, 86, 59, 132, 56, 40, 40, 120, 125, 172, 29, 49, 234, 179, 118, 168, 233, 60, 59, 235, 140, 55, 245, 72, 31, 183, 28, 61, 162, 180, 73, 74, 56, 26, 226, 236, 86, 180, 71, 179, 26, 33, 96, 173, 128, 206, 78, 122, 84, 52, 122, 30, 190, 235, 107, 249, 99, 76, 15, 246, 107, 158, 179, 175, 115, 101 }, null, new Guid("aba6e585-7cef-4efa-80be-6338ded67baf"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "Surname" },
                values: new object[] { new Guid("45766f15-1182-44d1-8527-960b4f2f7e0d"), "anatoliy.superadmin@gmail.com", "Anatoliy", new byte[] { 75, 165, 63, 153, 5, 112, 178, 109, 78, 150, 251, 157, 126, 230, 24, 153, 88, 202, 2, 24, 218, 99, 57, 22, 220, 178, 128, 33, 213, 247, 147, 151, 6, 247, 205, 12, 111, 25, 81, 37, 122, 218, 154, 227, 11, 17, 150, 245, 138, 100, 214, 58, 153, 110, 121, 42, 41, 52, 192, 238, 183, 168, 91, 141 }, new byte[] { 151, 198, 8, 20, 185, 10, 242, 26, 23, 105, 61, 167, 214, 188, 156, 179, 216, 181, 145, 184, 157, 247, 206, 237, 242, 48, 44, 168, 89, 43, 174, 147, 113, 113, 240, 105, 217, 141, 229, 13, 99, 59, 180, 206, 39, 23, 3, 137, 163, 152, 58, 76, 93, 248, 91, 150, 84, 213, 81, 160, 230, 194, 210, 86, 59, 132, 56, 40, 40, 120, 125, 172, 29, 49, 234, 179, 118, 168, 233, 60, 59, 235, 140, 55, 245, 72, 31, 183, 28, 61, 162, 180, 73, 74, 56, 26, 226, 236, 86, 180, 71, 179, 26, 33, 96, 173, 128, 206, 78, 122, 84, 52, 122, 30, 190, 235, 107, 249, 99, 76, 15, 246, 107, 158, 179, 175, 115, 101 }, null, new Guid("85cd66d7-2998-4f29-8319-f9cfc08859c7"), "Superadmin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "Surname" },
                values: new object[] { new Guid("dc52417a-0065-488b-aa94-b78524b8a2fe"), "roma.user@gmail.com", "Roma", new byte[] { 75, 165, 63, 153, 5, 112, 178, 109, 78, 150, 251, 157, 126, 230, 24, 153, 88, 202, 2, 24, 218, 99, 57, 22, 220, 178, 128, 33, 213, 247, 147, 151, 6, 247, 205, 12, 111, 25, 81, 37, 122, 218, 154, 227, 11, 17, 150, 245, 138, 100, 214, 58, 153, 110, 121, 42, 41, 52, 192, 238, 183, 168, 91, 141 }, new byte[] { 151, 198, 8, 20, 185, 10, 242, 26, 23, 105, 61, 167, 214, 188, 156, 179, 216, 181, 145, 184, 157, 247, 206, 237, 242, 48, 44, 168, 89, 43, 174, 147, 113, 113, 240, 105, 217, 141, 229, 13, 99, 59, 180, 206, 39, 23, 3, 137, 163, 152, 58, 76, 93, 248, 91, 150, 84, 213, 81, 160, 230, 194, 210, 86, 59, 132, 56, 40, 40, 120, 125, 172, 29, 49, 234, 179, 118, 168, 233, 60, 59, 235, 140, 55, 245, 72, 31, 183, 28, 61, 162, 180, 73, 74, 56, 26, 226, 236, 86, 180, 71, 179, 26, 33, 96, 173, 128, 206, 78, 122, 84, 52, 122, 30, 190, 235, 107, 249, 99, 76, 15, 246, 107, 158, 179, 175, 115, 101 }, null, new Guid("47cf14c1-6ab0-40d3-b48b-de72c8559976"), "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f08834d-02c8-49cc-b8d3-ca16b7b67459"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45766f15-1182-44d1-8527-960b4f2f7e0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc52417a-0065-488b-aa94-b78524b8a2fe"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("47cf14c1-6ab0-40d3-b48b-de72c8559976"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("85cd66d7-2998-4f29-8319-f9cfc08859c7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("aba6e585-7cef-4efa-80be-6338ded67baf"));
        }
    }
}
