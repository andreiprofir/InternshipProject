using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class CommentTypeTypeConfiguration : EntityTypeConfiguration<CommentType>
    {
        public CommentTypeTypeConfiguration()
        {
            Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(32);
        }
    }
}