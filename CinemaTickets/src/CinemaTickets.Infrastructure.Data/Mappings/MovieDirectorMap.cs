using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class MovieDirectorMap : IEntityTypeConfiguration<MovieDirector>
    {
        public void Configure(EntityTypeBuilder<MovieDirector> builder)
        {
            builder.HasKey(e => new { e.DirectorId, e.MovieId });

            builder.HasOne(d => d.Director)
                .WithMany(p => p.MovieDirectors)
                .HasForeignKey(d => d.DirectorId)
                .HasConstraintName("FK_MovieDirectors_Directors");

            builder.HasOne(d => d.Movie)
                .WithMany(p => p.MovieDirectors)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK_MovieDirectors_Movies");
        }
    }
}