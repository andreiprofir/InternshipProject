using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class MovieWriterMap : IEntityTypeConfiguration<MovieWriter>
    {
        public void Configure(EntityTypeBuilder<MovieWriter> builder)
        {
            builder.HasKey(e => new { e.MovieId, e.WriterId });

            builder.HasOne(d => d.Movie)
                .WithMany(p => p.MovieWriters)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK_MovieWriters_Movies");

            builder.HasOne(d => d.Writer)
                .WithMany(p => p.MovieWriters)
                .HasForeignKey(d => d.WriterId)
                .HasConstraintName("FK_MovieWriters_Writers");
        }
    }
}