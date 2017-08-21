using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class MovieTypeConfiguration : EntityTypeConfiguration<Movie>
    {
        public MovieTypeConfiguration()
        {
            HasMany(e => e.MovieSessions)
                .WithRequired(e => e.Movie)
                .HasForeignKey(e => e.MovieId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.Promotions)
                .WithMany(e => e.Movies)
                .Map(m => m.ToTable("MoviePromotions").MapLeftKey("MovieId").MapRightKey("PromotionId"));

            HasMany(e => e.Writers)
                .WithMany(e => e.Movies)
                .Map(m => m.ToTable("MovieWriters").MapLeftKey("MovieId").MapRightKey("WriterId"));
        }
    }
}