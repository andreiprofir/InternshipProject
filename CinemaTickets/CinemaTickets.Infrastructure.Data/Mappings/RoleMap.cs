using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Models;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            HasMany(e => e.Users)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("UserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));
        }
    }
}