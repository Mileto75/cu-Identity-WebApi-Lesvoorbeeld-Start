using cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace cu.ApiBasics.Lesvoorbeeld.Avond.Infrastructure.Data.Seeding
{
    public static class Seeder
    {
        
        public static void Seed(ModelBuilder modelBuilder)
        {
            IPasswordHasher<ApplicationUser> passwordHasher
                = new PasswordHasher<ApplicationUser>();
            //admin user
            var admin = new ApplicationUser
            {
                Id = "1",
                UserName = "admin@products.com",
                NormalizedUserName = "ADMIN@PRODUCTS.COM",
                Email = "admin@products.com",
                NormalizedEmail = "ADMIN@PRODUCTS.COM",
                Firstname = "Johnny",
                Lastname = "De Beer",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
            };
            //hash password
            admin.PasswordHash = passwordHasher.HashPassword(admin, "test");
            //add to applicationuser entity
            modelBuilder.Entity<ApplicationUser>().HasData(admin);
            modelBuilder.Entity<Category>().HasData
                (new Category[] {
                    new Category { Id = 1,Name = "Laptops" },
                    new Category { Id = 2,Name = "PC's" },
                    new Category { Id = 3,Name = "Phones" }
                });
            //add claim to user
            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string> { Id = 1, UserId = "1",
                ClaimType = ClaimTypes.Role, ClaimValue = "admin"});
            //another user
            var user = new ApplicationUser
            {
                Id = "2",
                UserName = "bart@products.com",
                NormalizedUserName = "BART@PRODUCTS.COM",
                Email = "bart@products.com",
                NormalizedEmail = "BART@PRODUCTS.COM",
                Firstname = "Bart",
                Lastname = "De Beer",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
            };
            //hash password
            user.PasswordHash = passwordHasher.HashPassword(user, "test");//only in development!
            //add to table
            modelBuilder.Entity<ApplicationUser>().HasData(user);
            //add claim
            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 2,
                    UserId = "2",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "customer"
                });
            modelBuilder.Entity<Property>().HasData(
                new Property[] { 
                    new Property { Id = 1, Name = "Basic"},
                    new Property { Id = 2, Name = "Luxury"},
                    new Property { Id = 3, Name = "Student"},
                    new Property { Id = 4, Name = "Family"},
                    new Property { Id = 5, Name = "Office"}
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product[] { 
                    new Product { Id = 1,Name="Samsung L7",Price=456.23M,CategoryId=3},
                    new Product { Id = 2,Name="Redmi Note7",Price=325.13M,CategoryId=3},
                    new Product { Id = 3,Name="Dell Latitude",Price=1456.23M,CategoryId=1},
                    new Product { Id = 4,Name="Dell Desktop",Price=856.3M,CategoryId=2},
                    new Product { Id = 5,Name="IBook 7",Price=2456.00M,CategoryId=1},
                    new Product { Id = 6,Name="Iphone12",Price=958.23M,CategoryId=3},
                }
                );
            modelBuilder.Entity($"{nameof(Product)}{nameof(Property)}").HasData
                (
                    new [] { 
                        new {ProductsId=1,PropertiesId=1},
                        new {ProductsId=1,PropertiesId=2},
                        new {ProductsId=1,PropertiesId=3},
                        new {ProductsId=2,PropertiesId=1},
                        new {ProductsId=2,PropertiesId=2},
                        new {ProductsId=2,PropertiesId=3},
                        new {ProductsId=3,PropertiesId=1},
                        new {ProductsId=3,PropertiesId=3},
                        new {ProductsId=4,PropertiesId=1},
                        new {ProductsId=5,PropertiesId=1},
                        new {ProductsId=5,PropertiesId=3},
                        new {ProductsId=6,PropertiesId=1},
                        new {ProductsId=6,PropertiesId=2},
                    }
                );
        }
    }
}
