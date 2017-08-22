using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Models;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            HasMany(e => e.Cinemas)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);
        }
    }
}