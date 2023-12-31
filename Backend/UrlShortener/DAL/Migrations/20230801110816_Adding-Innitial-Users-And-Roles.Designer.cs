﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(UrlShortenerContext))]
    [Migration("20230801110816_Adding-Innitial-Users-And-Roles")]
    partial class AddingInnitialUsersAndRoles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Model.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("47cf14c1-6ab0-40d3-b48b-de72c8559976"),
                            Name = "User"
                        },
                        new
                        {
                            Id = new Guid("aba6e585-7cef-4efa-80be-6338ded67baf"),
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("85cd66d7-2998-4f29-8319-f9cfc08859c7"),
                            Name = "SuperAdmin"
                        });
                });

            modelBuilder.Entity("DAL.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1f08834d-02c8-49cc-b8d3-ca16b7b67459"),
                            Email = "alex.admin@gmail.com",
                            Name = "Alex",
                            PasswordHash = new byte[] { 75, 165, 63, 153, 5, 112, 178, 109, 78, 150, 251, 157, 126, 230, 24, 153, 88, 202, 2, 24, 218, 99, 57, 22, 220, 178, 128, 33, 213, 247, 147, 151, 6, 247, 205, 12, 111, 25, 81, 37, 122, 218, 154, 227, 11, 17, 150, 245, 138, 100, 214, 58, 153, 110, 121, 42, 41, 52, 192, 238, 183, 168, 91, 141 },
                            PasswordSalt = new byte[] { 151, 198, 8, 20, 185, 10, 242, 26, 23, 105, 61, 167, 214, 188, 156, 179, 216, 181, 145, 184, 157, 247, 206, 237, 242, 48, 44, 168, 89, 43, 174, 147, 113, 113, 240, 105, 217, 141, 229, 13, 99, 59, 180, 206, 39, 23, 3, 137, 163, 152, 58, 76, 93, 248, 91, 150, 84, 213, 81, 160, 230, 194, 210, 86, 59, 132, 56, 40, 40, 120, 125, 172, 29, 49, 234, 179, 118, 168, 233, 60, 59, 235, 140, 55, 245, 72, 31, 183, 28, 61, 162, 180, 73, 74, 56, 26, 226, 236, 86, 180, 71, 179, 26, 33, 96, 173, 128, 206, 78, 122, 84, 52, 122, 30, 190, 235, 107, 249, 99, 76, 15, 246, 107, 158, 179, 175, 115, 101 },
                            RoleId = new Guid("aba6e585-7cef-4efa-80be-6338ded67baf"),
                            Surname = "Admin"
                        },
                        new
                        {
                            Id = new Guid("dc52417a-0065-488b-aa94-b78524b8a2fe"),
                            Email = "roma.user@gmail.com",
                            Name = "Roma",
                            PasswordHash = new byte[] { 75, 165, 63, 153, 5, 112, 178, 109, 78, 150, 251, 157, 126, 230, 24, 153, 88, 202, 2, 24, 218, 99, 57, 22, 220, 178, 128, 33, 213, 247, 147, 151, 6, 247, 205, 12, 111, 25, 81, 37, 122, 218, 154, 227, 11, 17, 150, 245, 138, 100, 214, 58, 153, 110, 121, 42, 41, 52, 192, 238, 183, 168, 91, 141 },
                            PasswordSalt = new byte[] { 151, 198, 8, 20, 185, 10, 242, 26, 23, 105, 61, 167, 214, 188, 156, 179, 216, 181, 145, 184, 157, 247, 206, 237, 242, 48, 44, 168, 89, 43, 174, 147, 113, 113, 240, 105, 217, 141, 229, 13, 99, 59, 180, 206, 39, 23, 3, 137, 163, 152, 58, 76, 93, 248, 91, 150, 84, 213, 81, 160, 230, 194, 210, 86, 59, 132, 56, 40, 40, 120, 125, 172, 29, 49, 234, 179, 118, 168, 233, 60, 59, 235, 140, 55, 245, 72, 31, 183, 28, 61, 162, 180, 73, 74, 56, 26, 226, 236, 86, 180, 71, 179, 26, 33, 96, 173, 128, 206, 78, 122, 84, 52, 122, 30, 190, 235, 107, 249, 99, 76, 15, 246, 107, 158, 179, 175, 115, 101 },
                            RoleId = new Guid("47cf14c1-6ab0-40d3-b48b-de72c8559976"),
                            Surname = "User"
                        },
                        new
                        {
                            Id = new Guid("45766f15-1182-44d1-8527-960b4f2f7e0d"),
                            Email = "anatoliy.superadmin@gmail.com",
                            Name = "Anatoliy",
                            PasswordHash = new byte[] { 75, 165, 63, 153, 5, 112, 178, 109, 78, 150, 251, 157, 126, 230, 24, 153, 88, 202, 2, 24, 218, 99, 57, 22, 220, 178, 128, 33, 213, 247, 147, 151, 6, 247, 205, 12, 111, 25, 81, 37, 122, 218, 154, 227, 11, 17, 150, 245, 138, 100, 214, 58, 153, 110, 121, 42, 41, 52, 192, 238, 183, 168, 91, 141 },
                            PasswordSalt = new byte[] { 151, 198, 8, 20, 185, 10, 242, 26, 23, 105, 61, 167, 214, 188, 156, 179, 216, 181, 145, 184, 157, 247, 206, 237, 242, 48, 44, 168, 89, 43, 174, 147, 113, 113, 240, 105, 217, 141, 229, 13, 99, 59, 180, 206, 39, 23, 3, 137, 163, 152, 58, 76, 93, 248, 91, 150, 84, 213, 81, 160, 230, 194, 210, 86, 59, 132, 56, 40, 40, 120, 125, 172, 29, 49, 234, 179, 118, 168, 233, 60, 59, 235, 140, 55, 245, 72, 31, 183, 28, 61, 162, 180, 73, 74, 56, 26, 226, 236, 86, 180, 71, 179, 26, 33, 96, 173, 128, 206, 78, 122, 84, 52, 122, 30, 190, 235, 107, 249, 99, 76, 15, 246, 107, 158, 179, 175, 115, 101 },
                            RoleId = new Guid("85cd66d7-2998-4f29-8319-f9cfc08859c7"),
                            Surname = "Superadmin"
                        });
                });

            modelBuilder.Entity("DAL.Model.User", b =>
                {
                    b.HasOne("DAL.Model.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DAL.Model.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
