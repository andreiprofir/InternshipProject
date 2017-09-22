using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class MovieSessionMap : IEntityTypeConfiguration<MovieSession>
    {
        public void Configure(EntityTypeBuilder<MovieSession> builder)
        {
            builder.HasOne(d => d.Hall)
                .WithMany(p => p.MovieSessions)
                .HasForeignKey(d => d.HallId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovieSessions_Halls");

            builder.HasOne(d => d.Movie)
                .WithMany(p => p.MovieSessions)
                .HasForeignKey(d => d.MovieId)
                //.OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovieSessions_Movies");
        }
    }
}