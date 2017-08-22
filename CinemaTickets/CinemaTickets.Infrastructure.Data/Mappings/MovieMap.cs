using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Classes;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class MovieMap : EntityTypeConfiguration<Movie>
    {
        public MovieMap()
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