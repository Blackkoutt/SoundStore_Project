using Azure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Projekt_.NET.Models;

namespace Projekt_.NET.Extenssions
{
    public static class ModelBuilderExtensionscs
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            /*var passwordHasher = new PasswordHasher<string>();
            modelBuilder.Entity<Users>().HasData(
                new Users()
                {
                    Id = 1,
                    Username = "admin",
                    Password = passwordHasher.HashPassword("admin", "admin"),
                    Role = "admin"
                },
                new Users()
                {
                    Id = 2,
                    Username = "user",
                    Password = passwordHasher.HashPassword("user", "user"),
                    Role = "user"
                },
                new Users()
                {
                    Id = 3,
                    Username = "moderator",
                    Password = passwordHasher.HashPassword("moderator", "moderator"),
                    Role = "moderator"
                }

                );*/

            modelBuilder.Entity<Distributor>().HasData(
                new Distributor()
                {
                    Id = 1,
                    Name = "Sony Music Entertainment",
                },
                new Distributor()
                {
                    Id = 2,
                    Name = "Universal Music Polska"
                });
            modelBuilder.Entity<Producer>().HasData(
                    new Producer()
                    {
                        Id = 1,
                        Name = "Sony Music Entertainment"
                    },
                    new Producer()
                    {
                        Id = 2,
                        Name = "Universal Music Group"
                    }
                );
            modelBuilder.Entity<Category>().HasData(
                    new Category()
                    {
                        Id = 1,
                        Name = "Rap & Hip-Hop"
                    },
                    new Category()
                    {
                        Id = 2,
                        Name = "Rap & Hip-Hop2"
                    }
                );
            modelBuilder.Entity<Performer>().HasData(
                    new Performer()
                    {
                        Id = 1,
                        Name = "Travis Scott"
                    },
                    new Performer()
                    {
                        Id = 2,
                        Name = "Juice WRLD"
                    }
                );
        }
    }
}
