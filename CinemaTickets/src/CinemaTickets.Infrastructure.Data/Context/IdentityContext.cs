using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Infrastructure.Data.Models;
using CinemaTickets.Infrastructure.Data.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaTickets.Infrastructure.Data.Context
{
    public class IdentityContext : IdentityDbContext<User, Role, long>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<UserCustomer>()
                .Property(e => e.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<User>()
                .HasOne(e => e.Customer)
                .WithOne(e => e.User)
                .HasForeignKey<UserCustomer>(e => e.Id);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Customer>().ToTable("Users");

            modelBuilder.Entity<Role>()
                .ToTable("Roles");

            modelBuilder.Entity<IdentityUserRole<long>>()
                .ToTable("UserRoles");

            modelBuilder.Entity<IdentityUserToken<long>>()
                .ToTable("UserTokens");

            modelBuilder.Ignore<IdentityUserLogin<long>>();
            modelBuilder.Ignore<IdentityUserClaim<long>>();
            modelBuilder.Ignore<IdentityRoleClaim<long>>();
        }
    }
}