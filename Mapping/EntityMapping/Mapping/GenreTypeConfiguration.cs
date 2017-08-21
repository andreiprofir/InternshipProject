using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class GenreTypeConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreTypeConfiguration()
        {
            HasMany(e => e.Movies)
                .WithMany(e => e.Genres)
                .Map(m => m.ToTable("MovieGenres").MapLeftKey("GenreId").MapRightKey("MovieId"));
        }
    }
}