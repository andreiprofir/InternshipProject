using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class MovieActorMap : IEntityTypeConfiguration<MovieActor>
    {
        public void Configure(EntityTypeBuilder<MovieActor> builder)
        {
            builder.HasKey(e => new { e.ActorId, e.MovieId });

            builder.HasOne(d => d.Actor)
                .WithMany(p => p.MovieActors)
                .HasForeignKey(d => d.ActorId)
                .HasConstraintName("FK_MovieActors_Actors");

            builder.HasOne(d => d.Movie)
                .WithMany(p => p.MovieActors)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK_MovieActors_Movies");
        }
    }
}