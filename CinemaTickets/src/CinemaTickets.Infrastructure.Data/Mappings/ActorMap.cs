using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class ActorMap : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> entity)
        {
            entity.HasIndex(e => new { e.FirstName, e.LastName })
                .HasName("AK_Actors_FirstName_LastName")
                .IsUnique();

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(64);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(64);
        }
    }
}