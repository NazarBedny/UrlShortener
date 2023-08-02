using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddingANewFieldsInUrlModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "UrlModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UrlModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.CreateIndex(
                name: "IX_UrlModels_CreatedById",
                table: "UrlModels",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_UrlModels_Users_CreatedById",
                table: "UrlModels",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UrlModels_Users_CreatedById",
                table: "UrlModels");

            migrationBuilder.DropIndex(
                name: "IX_UrlModels_CreatedById",
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

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "UrlModels");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UrlModels");

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
    }
}
