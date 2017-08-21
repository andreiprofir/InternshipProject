using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class PictureTypeConfiguration : EntityTypeConfiguration<Picture>
    {
        public PictureTypeConfiguration()
        {
            HasMany(e => e.Users)
                .WithOptional(e => e.Picture)
                .HasForeignKey(e => e.AvatarId);
        }
    }
}