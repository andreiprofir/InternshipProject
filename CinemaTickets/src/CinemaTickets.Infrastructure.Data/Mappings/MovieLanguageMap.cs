using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class MovieLanguageMap : IEntityTypeConfiguration<MovieLanguage>
    {
        public void Configure(EntityTypeBuilder<MovieLanguage> builder)
        {
            builder.HasKey(e => new { e.LanguageId, e.MovieId });

            builder.HasOne(d => d.Language)
                .WithMany(p => p.MovieLanguages)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_MovieLanguages_Languages");

            builder.HasOne(d => d.Movie)
                .WithMany(p => p.MovieLanguages)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK_MovieLanguages_Movies");
        }
    }
}