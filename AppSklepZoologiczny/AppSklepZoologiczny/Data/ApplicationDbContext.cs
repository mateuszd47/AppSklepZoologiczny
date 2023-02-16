using AppSklepZoologiczny.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppSklepZoologiczny.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deliveries> Deliveriess { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            #region Roles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "ADMIN", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
                new IdentityRole() { Name = "USER", ConcurrencyStamp = "2", NormalizedName = "USER" },
                new IdentityRole() { Name = "CUSTOMER", ConcurrencyStamp = "3", NormalizedName = "CUSTOMER" }
                );

            #endregion

            //#region Users
            //var admin = new IdentityUser()
            //{
            //    Id = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb",
            //    Email = "admin@domain.com",
            //    NormalizedEmail = "ADMIN@DOMAIN.COM",
            //    UserName = "Administrator",
            //    NormalizedUserName = "Administrator",
            //    EmailConfirmed = true,
            //    SecurityStamp = Guid.NewGuid().ToString(),
            //};

            //var passwordHasher = new PasswordHasher<IdentityUser>();
            //admin.PasswordHash = passwordHasher.HashPassword(admin, "admin");

            //builder.Entity<IdentityUser>().HasData(admin);
            //#endregion

            

            //#region Assign roles to users
            //builder.Entity<IdentityUserRole<string>>().HasData(
            //    new IdentityUserRole<string>() { RoleId = "68bdf9cb-4866-444d-8cf5-56d54170dc81", UserId = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb" }
            //    );
            //#endregion
        }
    }
}
