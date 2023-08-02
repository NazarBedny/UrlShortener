using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class UrlShortenerContext : DbContext
    {
        public UrlShortenerContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UrlModel> UrlModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // make one-to-one connection
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        public class RoleConfiguration : IEntityTypeConfiguration<Role>
        {
            public void Configure(EntityTypeBuilder<Role> builder)
            {
                builder.HasData(
                    new Role { Id = Guid.Parse("47cf14c1-6ab0-40d3-b48b-de72c8559976"), Name = "User" },
                    new Role { Id = Guid.Parse("aba6e585-7cef-4efa-80be-6338ded67baf"), Name = "Administrator" },
                    new Role { Id = Guid.Parse("85cd66d7-2998-4f29-8319-f9cfc08859c7"), Name = "SuperAdmin" }
                    );
            }
        }
        public class UserConfiguration : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                CreatePasswordHash("qwerty", out byte[] passwordHash, out byte[] passwordSalt);

                builder.HasData(
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Name = "Alex",
                        Surname = "Admin",
                        Email = "alex.admin@gmail.com",
                        PasswordHash = passwordHash,
                        PasswordSalt = passwordSalt,
                        RoleId = Guid.Parse("aba6e585-7cef-4efa-80be-6338ded67baf"),
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Name = "Roma",
                        Surname = "User",
                        Email = "roma.user@gmail.com",
                        PasswordHash = passwordHash,
                        PasswordSalt = passwordSalt,
                        RoleId = Guid.Parse("47cf14c1-6ab0-40d3-b48b-de72c8559976"),
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Name = "Anatoliy",
                        Surname = "Superadmin",
                        Email = "anatoliy.superadmin@gmail.com",
                        PasswordHash = passwordHash,
                        PasswordSalt = passwordSalt,
                        RoleId = Guid.Parse("85cd66d7-2998-4f29-8319-f9cfc08859c7"),
                    });

            }

            private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
            {
                using (var hmac = new HMACSHA512())
                {
                    passwordSalt = hmac.Key;
                    passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                }
            }

        }
    }
}
