using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class MovieCountryMap : IEntityTypeConfiguration<MovieCountry>
    {
        public void Configure(EntityTypeBuilder<MovieCountry> builder)
        {
            builder.HasKey(e => new { e.CountryId, e.MovieId });

            builder.HasOne(d => d.Country)
                .WithMany(p => p.MovieCountries)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_MovieCountries_Countries");

            builder.HasOne(d => d.Movie)
                .WithMany(p => p.MovieCountries)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK_MovieCountries_Movies");
        }
    }
}