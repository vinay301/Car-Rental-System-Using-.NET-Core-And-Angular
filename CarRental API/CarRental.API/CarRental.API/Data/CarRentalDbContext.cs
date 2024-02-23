using CarRental.API.Data.Entity;
using CarRental.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRental.API.Data
{
    public class CarRentalDbContext : IdentityDbContext
    {
        public CarRentalDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cars> Cars { get; set; }
       

       

        public DbSet<CarRentalAgreement> CarRentalAgreements { get; set; }

        //Model builder takes the entity and send this to the sql
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           

            //Role Seed
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN".ToUpper() },
                new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER".ToUpper() }
            );

            var userID1 = Guid.NewGuid().ToString();
            var userID2 = Guid.NewGuid().ToString();



            //Password Hasher
            var hasher = new PasswordHasher<IdentityUser>();


            //User Seed
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = userID1,
                    
                    Email = "admin@test.com",
                    NormalizedEmail = "admin@test.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "adminpassword")
                },
                new IdentityUser
                {
                    Id = userID2,
                    
                    Email = "user@test.com",
                    NormalizedEmail = "user@test.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "userpassword")
                }
            );

            //Assigning Roles
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = userID1, RoleId = "1" },
                new IdentityUserRole<string> { UserId = userID2, RoleId = "2" }
            );
        }
    }
}
