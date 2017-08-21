using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class RoleTypeConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleTypeConfiguration()
        {
            HasMany(e => e.Users)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("UserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));
        }
    }
}