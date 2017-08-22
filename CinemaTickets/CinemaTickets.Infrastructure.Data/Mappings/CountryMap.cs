using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Classes;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            HasMany(e => e.Movies)
                .WithMany(e => e.Countries)
                .Map(m => m.ToTable("MovieCountries").MapLeftKey("CountryId").MapRightKey("MovieId"));
        }
    }
}