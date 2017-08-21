using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class MovieSessionTypeConfiguration : EntityTypeConfiguration<MovieSession>
    {
        public MovieSessionTypeConfiguration()
        {
            HasMany(e => e.Orders)
                .WithRequired(e => e.MovieSession)
                .WillCascadeOnDelete(false);

            HasMany(e => e.SessionPrices)
                .WithRequired(e => e.MovieSession)
                .WillCascadeOnDelete(false);
        }
    }
}