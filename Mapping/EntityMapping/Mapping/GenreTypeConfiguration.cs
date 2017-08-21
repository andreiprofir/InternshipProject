using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class GenreTypeConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreTypeConfiguration()
        {
            HasRequired(e => e.Entity)
                .WithOptional()
                .WillCascadeOnDelete(true);

            HasMany(e => e.Movies)
                .WithMany(e => e.Genres)
                .Map(m => m.ToTable("MovieGenres").MapLeftKey("GenreId").MapRightKey("MovieId"));
        }
    }
}