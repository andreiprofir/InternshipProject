using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Classes;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class MovieSessionMap : EntityTypeConfiguration<MovieSession>
    {
        public MovieSessionMap()
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