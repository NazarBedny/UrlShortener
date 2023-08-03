using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class FixBugInContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UrlModels_Users_CreatedById",
                table: "UrlModels");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1417bdfe-a80b-4168-aab4-5c7ae5647b90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("629dcaae-1972-49af-b220-fc74bf3fb569"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86becf42-cd7a-4f94-8674-e30f6c457167"));

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "UrlModels",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UrlModels_CreatedById",
                table: "UrlModels",
                newName: "IX_UrlModels_UserId");

            migrationBuilder.AddColumn<Guid>(
                name: "UrlId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_UrlModels_Users_UserId",
                table: "UrlModels",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UrlModels_Users_UserId",
                table: "UrlModels");

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

            migrationBuilder.DropColumn(
                name: "UrlId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UrlModels",
                newName: "CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_UrlModels_UserId",
                table: "UrlModels",
                newName: "IX_UrlModels_CreatedById");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "Surname" },
                values: new object[] { new Guid("1417bdfe-a80b-4168-aab4-5c7ae5647b90"), "alex.admin@gmail.com", "Alex", new byte[] { 120, 158, 204, 198, 125, 32, 70, 202, 216, 212, 25, 101, 117, 166, 182, 166, 238, 156, 245, 142, 63, 228, 57, 45, 144, 150, 6, 195, 211, 160, 74, 64, 222, 24, 82, 238, 25, 135, 75, 85, 122, 120, 181, 163, 151, 79, 86, 189, 101, 21, 166, 81, 133, 109, 158, 100, 162, 191, 32, 59, 123, 207, 165, 86 }, new byte[] { 185, 125, 248, 101, 14, 180, 137, 107, 51, 93, 73, 99, 213, 109, 203, 145, 158, 61, 55, 2, 72, 135, 142, 20, 71, 53, 188, 109, 49, 2, 48, 117, 126, 73, 93, 235, 233, 0, 86, 139, 44, 45, 173, 222, 210, 55, 42, 10, 1, 39, 227, 105, 139, 144, 32, 113, 155, 164, 221, 139, 155, 141, 20, 228, 227, 195, 102, 241, 73, 42, 168, 107, 161, 8, 197, 27, 8, 151, 68, 113, 59, 182, 214, 71, 66, 255, 85, 181, 9, 16, 194, 175, 82, 237, 166, 172, 188, 227, 132, 154, 130, 206, 190, 36, 201, 198, 175, 144, 45, 161, 42, 2, 230, 92, 224, 181, 216, 199, 36, 0, 60, 232, 38, 244, 21, 77, 199, 149 }, null, new Guid("aba6e585-7cef-4efa-80be-6338ded67baf"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "Surname" },
                values: new object[] { new Guid("629dcaae-1972-49af-b220-fc74bf3fb569"), "anatoliy.superadmin@gmail.com", "Anatoliy", new byte[] { 120, 158, 204, 198, 125, 32, 70, 202, 216, 212, 25, 101, 117, 166, 182, 166, 238, 156, 245, 142, 63, 228, 57, 45, 144, 150, 6, 195, 211, 160, 74, 64, 222, 24, 82, 238, 25, 135, 75, 85, 122, 120, 181, 163, 151, 79, 86, 189, 101, 21, 166, 81, 133, 109, 158, 100, 162, 191, 32, 59, 123, 207, 165, 86 }, new byte[] { 185, 125, 248, 101, 14, 180, 137, 107, 51, 93, 73, 99, 213, 109, 203, 145, 158, 61, 55, 2, 72, 135, 142, 20, 71, 53, 188, 109, 49, 2, 48, 117, 126, 73, 93, 235, 233, 0, 86, 139, 44, 45, 173, 222, 210, 55, 42, 10, 1, 39, 227, 105, 139, 144, 32, 113, 155, 164, 221, 139, 155, 141, 20, 228, 227, 195, 102, 241, 73, 42, 168, 107, 161, 8, 197, 27, 8, 151, 68, 113, 59, 182, 214, 71, 66, 255, 85, 181, 9, 16, 194, 175, 82, 237, 166, 172, 188, 227, 132, 154, 130, 206, 190, 36, 201, 198, 175, 144, 45, 161, 42, 2, 230, 92, 224, 181, 216, 199, 36, 0, 60, 232, 38, 244, 21, 77, 199, 149 }, null, new Guid("85cd66d7-2998-4f29-8319-f9cfc08859c7"), "Superadmin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "Surname" },
                values: new object[] { new Guid("86becf42-cd7a-4f94-8674-e30f6c457167"), "roma.user@gmail.com", "Roma", new byte[] { 120, 158, 204, 198, 125, 32, 70, 202, 216, 212, 25, 101, 117, 166, 182, 166, 238, 156, 245, 142, 63, 228, 57, 45, 144, 150, 6, 195, 211, 160, 74, 64, 222, 24, 82, 238, 25, 135, 75, 85, 122, 120, 181, 163, 151, 79, 86, 189, 101, 21, 166, 81, 133, 109, 158, 100, 162, 191, 32, 59, 123, 207, 165, 86 }, new byte[] { 185, 125, 248, 101, 14, 180, 137, 107, 51, 93, 73, 99, 213, 109, 203, 145, 158, 61, 55, 2, 72, 135, 142, 20, 71, 53, 188, 109, 49, 2, 48, 117, 126, 73, 93, 235, 233, 0, 86, 139, 44, 45, 173, 222, 210, 55, 42, 10, 1, 39, 227, 105, 139, 144, 32, 113, 155, 164, 221, 139, 155, 141, 20, 228, 227, 195, 102, 241, 73, 42, 168, 107, 161, 8, 197, 27, 8, 151, 68, 113, 59, 182, 214, 71, 66, 255, 85, 181, 9, 16, 194, 175, 82, 237, 166, 172, 188, 227, 132, 154, 130, 206, 190, 36, 201, 198, 175, 144, 45, 161, 42, 2, 230, 92, 224, 181, 216, 199, 36, 0, 60, 232, 38, 244, 21, 77, 199, 149 }, null, new Guid("47cf14c1-6ab0-40d3-b48b-de72c8559976"), "User" });

            migrationBuilder.AddForeignKey(
                name: "FK_UrlModels_Users_CreatedById",
                table: "UrlModels",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
