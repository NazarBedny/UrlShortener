﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddingUrlModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UrlModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginalURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortenedURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "Surname" },
                values: new object[] { new Guid("0370d822-13a5-4767-aa6d-d234243d632b"), "anatoliy.superadmin@gmail.com", "Anatoliy", new byte[] { 42, 59, 35, 247, 158, 99, 121, 124, 251, 45, 164, 174, 30, 138, 204, 229, 118, 34, 95, 239, 119, 85, 187, 219, 116, 28, 31, 251, 167, 184, 181, 94, 228, 107, 220, 42, 28, 253, 220, 240, 208, 93, 155, 209, 167, 167, 232, 213, 104, 12, 111, 140, 32, 182, 129, 247, 247, 188, 76, 46, 178, 100, 144, 9 }, new byte[] { 113, 85, 230, 57, 73, 243, 45, 122, 15, 220, 174, 193, 22, 156, 76, 193, 4, 155, 11, 41, 223, 171, 76, 223, 117, 57, 135, 22, 97, 86, 122, 198, 97, 36, 34, 96, 190, 229, 172, 51, 86, 251, 249, 28, 170, 200, 72, 195, 112, 145, 138, 186, 21, 177, 160, 143, 148, 193, 10, 71, 101, 139, 103, 233, 157, 183, 27, 143, 9, 135, 22, 226, 254, 50, 237, 63, 85, 79, 63, 25, 107, 65, 43, 25, 171, 55, 67, 50, 4, 195, 206, 175, 213, 48, 195, 31, 190, 157, 78, 250, 255, 37, 123, 78, 214, 197, 201, 180, 189, 26, 15, 121, 5, 180, 213, 191, 76, 149, 195, 221, 4, 27, 140, 89, 191, 13, 206, 110 }, null, new Guid("85cd66d7-2998-4f29-8319-f9cfc08859c7"), "Superadmin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "Surname" },
                values: new object[] { new Guid("f45cab0a-301d-4aae-97de-4764fb9e92da"), "alex.admin@gmail.com", "Alex", new byte[] { 42, 59, 35, 247, 158, 99, 121, 124, 251, 45, 164, 174, 30, 138, 204, 229, 118, 34, 95, 239, 119, 85, 187, 219, 116, 28, 31, 251, 167, 184, 181, 94, 228, 107, 220, 42, 28, 253, 220, 240, 208, 93, 155, 209, 167, 167, 232, 213, 104, 12, 111, 140, 32, 182, 129, 247, 247, 188, 76, 46, 178, 100, 144, 9 }, new byte[] { 113, 85, 230, 57, 73, 243, 45, 122, 15, 220, 174, 193, 22, 156, 76, 193, 4, 155, 11, 41, 223, 171, 76, 223, 117, 57, 135, 22, 97, 86, 122, 198, 97, 36, 34, 96, 190, 229, 172, 51, 86, 251, 249, 28, 170, 200, 72, 195, 112, 145, 138, 186, 21, 177, 160, 143, 148, 193, 10, 71, 101, 139, 103, 233, 157, 183, 27, 143, 9, 135, 22, 226, 254, 50, 237, 63, 85, 79, 63, 25, 107, 65, 43, 25, 171, 55, 67, 50, 4, 195, 206, 175, 213, 48, 195, 31, 190, 157, 78, 250, 255, 37, 123, 78, 214, 197, 201, 180, 189, 26, 15, 121, 5, 180, 213, 191, 76, 149, 195, 221, 4, 27, 140, 89, 191, 13, 206, 110 }, null, new Guid("aba6e585-7cef-4efa-80be-6338ded67baf"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "Surname" },
                values: new object[] { new Guid("fef6da98-e7db-42bf-ae17-e7c879ccb77f"), "roma.user@gmail.com", "Roma", new byte[] { 42, 59, 35, 247, 158, 99, 121, 124, 251, 45, 164, 174, 30, 138, 204, 229, 118, 34, 95, 239, 119, 85, 187, 219, 116, 28, 31, 251, 167, 184, 181, 94, 228, 107, 220, 42, 28, 253, 220, 240, 208, 93, 155, 209, 167, 167, 232, 213, 104, 12, 111, 140, 32, 182, 129, 247, 247, 188, 76, 46, 178, 100, 144, 9 }, new byte[] { 113, 85, 230, 57, 73, 243, 45, 122, 15, 220, 174, 193, 22, 156, 76, 193, 4, 155, 11, 41, 223, 171, 76, 223, 117, 57, 135, 22, 97, 86, 122, 198, 97, 36, 34, 96, 190, 229, 172, 51, 86, 251, 249, 28, 170, 200, 72, 195, 112, 145, 138, 186, 21, 177, 160, 143, 148, 193, 10, 71, 101, 139, 103, 233, 157, 183, 27, 143, 9, 135, 22, 226, 254, 50, 237, 63, 85, 79, 63, 25, 107, 65, 43, 25, 171, 55, 67, 50, 4, 195, 206, 175, 213, 48, 195, 31, 190, 157, 78, 250, 255, 37, 123, 78, 214, 197, 201, 180, 189, 26, 15, 121, 5, 180, 213, 191, 76, 149, 195, 221, 4, 27, 140, 89, 191, 13, 206, 110 }, null, new Guid("47cf14c1-6ab0-40d3-b48b-de72c8559976"), "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrlModels");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0370d822-13a5-4767-aa6d-d234243d632b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f45cab0a-301d-4aae-97de-4764fb9e92da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fef6da98-e7db-42bf-ae17-e7c879ccb77f"));

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
    }
}
