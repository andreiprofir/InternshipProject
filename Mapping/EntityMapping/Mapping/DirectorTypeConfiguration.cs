using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class DirectorTypeConfiguration : EntityTypeConfiguration<Director>
    {
        public DirectorTypeConfiguration()
        {
            HasMany(e => e.Movies)
                .WithMany(e => e.Directors)
                .Map(m => m.ToTable("MovieDirectors").MapLeftKey("DirectorId").MapRightKey("MovieId"));
        }
    }
}