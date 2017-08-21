using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class DirectorTypeConfiguration : EntityTypeConfiguration<Director>
    {
        public DirectorTypeConfiguration()
        {
            Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(64);

            Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(64);

            HasMany(e => e.Movies)
                .WithMany(e => e.Directors)
                .Map(m => m.ToTable("MovieDirectors").MapLeftKey("DirectorId").MapRightKey("MovieId"));
        }
    }
}