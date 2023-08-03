using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Fixafewfieldsinusermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00285994-92f4-4995-8fa5-44989e3eab07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15ae95f7-118f-439b-8966-f8811185afe6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5598d6df-69ae-4a91-9084-758880265f17"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("85cd66d7-2998-4f29-8319-f9cfc08859c7"));

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UrlId",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "RoleId", "Surname" },
                values: new object[] { new Guid("1e830091-5c1b-4f1a-b061-45091331a8c2"), "alex.admin@gmail.com", "Alex", new byte[] { 249, 202, 167, 133, 241, 31, 184, 23, 248, 29, 72, 212, 98, 98, 57, 111, 102, 72, 14, 43, 25, 155, 127, 103, 86, 85, 167, 16, 2, 147, 88, 232, 95, 184, 28, 31, 219, 188, 88, 134, 0, 151, 140, 63, 113, 50, 172, 182, 48, 170, 49, 25, 83, 59, 33, 207, 111, 251, 99, 78, 118, 166, 122, 206 }, new byte[] { 173, 224, 182, 188, 192, 205, 146, 105, 64, 169, 96, 83, 46, 72, 108, 129, 171, 110, 254, 15, 99, 55, 139, 222, 150, 179, 72, 122, 136, 74, 31, 18, 201, 53, 253, 121, 6, 106, 169, 47, 37, 122, 39, 83, 117, 255, 49, 201, 244, 147, 31, 99, 161, 92, 234, 234, 104, 218, 32, 8, 13, 24, 30, 41, 114, 16, 162, 125, 21, 244, 177, 1, 21, 151, 138, 121, 54, 67, 9, 69, 200, 53, 87, 176, 8, 120, 85, 232, 140, 232, 199, 76, 50, 193, 129, 177, 40, 105, 226, 43, 170, 19, 177, 230, 142, 254, 90, 30, 244, 163, 147, 50, 205, 15, 101, 152, 218, 254, 223, 193, 77, 103, 166, 225, 240, 73, 169, 87 }, new Guid("aba6e585-7cef-4efa-80be-6338ded67baf"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "RoleId", "Surname" },
                values: new object[] { new Guid("941029b8-5140-40be-a7c3-e80b526566bc"), "roma.user@gmail.com", "Roma", new byte[] { 249, 202, 167, 133, 241, 31, 184, 23, 248, 29, 72, 212, 98, 98, 57, 111, 102, 72, 14, 43, 25, 155, 127, 103, 86, 85, 167, 16, 2, 147, 88, 232, 95, 184, 28, 31, 219, 188, 88, 134, 0, 151, 140, 63, 113, 50, 172, 182, 48, 170, 49, 25, 83, 59, 33, 207, 111, 251, 99, 78, 118, 166, 122, 206 }, new byte[] { 173, 224, 182, 188, 192, 205, 146, 105, 64, 169, 96, 83, 46, 72, 108, 129, 171, 110, 254, 15, 99, 55, 139, 222, 150, 179, 72, 122, 136, 74, 31, 18, 201, 53, 253, 121, 6, 106, 169, 47, 37, 122, 39, 83, 117, 255, 49, 201, 244, 147, 31, 99, 161, 92, 234, 234, 104, 218, 32, 8, 13, 24, 30, 41, 114, 16, 162, 125, 21, 244, 177, 1, 21, 151, 138, 121, 54, 67, 9, 69, 200, 53, 87, 176, 8, 120, 85, 232, 140, 232, 199, 76, 50, 193, 129, 177, 40, 105, 226, 43, 170, 19, 177, 230, 142, 254, 90, 30, 244, 163, 147, 50, 205, 15, 101, 152, 218, 254, 223, 193, 77, 103, 166, 225, 240, 73, 169, 87 }, new Guid("47cf14c1-6ab0-40d3-b48b-de72c8559976"), "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e830091-5c1b-4f1a-b061-45091331a8c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("941029b8-5140-40be-a7c3-e80b526566bc"));

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UrlId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("85cd66d7-2998-4f29-8319-f9cfc08859c7"), "SuperAdmin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "Surname", "UrlId" },
                values: new object[] { new Guid("00285994-92f4-4995-8fa5-44989e3eab07"), "alex.admin@gmail.com", "Alex", new byte[] { 149, 110, 172, 76, 116, 193, 57, 53, 164, 123, 122, 167, 223, 26, 137, 129, 238, 80, 235, 235, 200, 161, 193, 56, 89, 109, 18, 175, 212, 181, 25, 29, 132, 48, 49, 207, 85, 17, 141, 213, 50, 153, 234, 64, 66, 195, 139, 15, 202, 13, 245, 86, 234, 38, 143, 250, 223, 170, 226, 133, 151, 106, 21, 72 }, new byte[] { 119, 82, 207, 149, 164, 199, 50, 18, 44, 92, 193, 197, 16, 244, 57, 219, 41, 138, 128, 36, 186, 76, 142, 51, 82, 220, 142, 118, 206, 222, 234, 12, 125, 118, 107, 97, 108, 11, 147, 18, 0, 6, 82, 210, 42, 170, 28, 199, 92, 240, 23, 95, 107, 45, 180, 176, 53, 78, 126, 113, 182, 151, 124, 143, 212, 137, 57, 230, 77, 236, 155, 69, 74, 2, 35, 94, 128, 235, 69, 34, 54, 101, 2, 177, 23, 134, 79, 61, 1, 10, 254, 126, 15, 37, 55, 12, 222, 226, 171, 106, 161, 210, 227, 188, 1, 182, 242, 161, 252, 74, 17, 75, 139, 12, 21, 82, 93, 63, 96, 156, 45, 26, 247, 91, 166, 172, 234, 213 }, null, new Guid("aba6e585-7cef-4efa-80be-6338ded67baf"), "Admin", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "Surname", "UrlId" },
                values: new object[] { new Guid("15ae95f7-118f-439b-8966-f8811185afe6"), "roma.user@gmail.com", "Roma", new byte[] { 149, 110, 172, 76, 116, 193, 57, 53, 164, 123, 122, 167, 223, 26, 137, 129, 238, 80, 235, 235, 200, 161, 193, 56, 89, 109, 18, 175, 212, 181, 25, 29, 132, 48, 49, 207, 85, 17, 141, 213, 50, 153, 234, 64, 66, 195, 139, 15, 202, 13, 245, 86, 234, 38, 143, 250, 223, 170, 226, 133, 151, 106, 21, 72 }, new byte[] { 119, 82, 207, 149, 164, 199, 50, 18, 44, 92, 193, 197, 16, 244, 57, 219, 41, 138, 128, 36, 186, 76, 142, 51, 82, 220, 142, 118, 206, 222, 234, 12, 125, 118, 107, 97, 108, 11, 147, 18, 0, 6, 82, 210, 42, 170, 28, 199, 92, 240, 23, 95, 107, 45, 180, 176, 53, 78, 126, 113, 182, 151, 124, 143, 212, 137, 57, 230, 77, 236, 155, 69, 74, 2, 35, 94, 128, 235, 69, 34, 54, 101, 2, 177, 23, 134, 79, 61, 1, 10, 254, 126, 15, 37, 55, 12, 222, 226, 171, 106, 161, 210, 227, 188, 1, 182, 242, 161, 252, 74, 17, 75, 139, 12, 21, 82, 93, 63, 96, 156, 45, 26, 247, 91, 166, 172, 234, 213 }, null, new Guid("47cf14c1-6ab0-40d3-b48b-de72c8559976"), "User", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "Surname", "UrlId" },
                values: new object[] { new Guid("5598d6df-69ae-4a91-9084-758880265f17"), "anatoliy.superadmin@gmail.com", "Anatoliy", new byte[] { 149, 110, 172, 76, 116, 193, 57, 53, 164, 123, 122, 167, 223, 26, 137, 129, 238, 80, 235, 235, 200, 161, 193, 56, 89, 109, 18, 175, 212, 181, 25, 29, 132, 48, 49, 207, 85, 17, 141, 213, 50, 153, 234, 64, 66, 195, 139, 15, 202, 13, 245, 86, 234, 38, 143, 250, 223, 170, 226, 133, 151, 106, 21, 72 }, new byte[] { 119, 82, 207, 149, 164, 199, 50, 18, 44, 92, 193, 197, 16, 244, 57, 219, 41, 138, 128, 36, 186, 76, 142, 51, 82, 220, 142, 118, 206, 222, 234, 12, 125, 118, 107, 97, 108, 11, 147, 18, 0, 6, 82, 210, 42, 170, 28, 199, 92, 240, 23, 95, 107, 45, 180, 176, 53, 78, 126, 113, 182, 151, 124, 143, 212, 137, 57, 230, 77, 236, 155, 69, 74, 2, 35, 94, 128, 235, 69, 34, 54, 101, 2, 177, 23, 134, 79, 61, 1, 10, 254, 126, 15, 37, 55, 12, 222, 226, 171, 106, 161, 210, 227, 188, 1, 182, 242, 161, 252, 74, 17, 75, 139, 12, 21, 82, 93, 63, 96, 156, 45, 26, 247, 91, 166, 172, 234, 213 }, null, new Guid("85cd66d7-2998-4f29-8319-f9cfc08859c7"), "Superadmin", new Guid("00000000-0000-0000-0000-000000000000") });
        }
    }
}
