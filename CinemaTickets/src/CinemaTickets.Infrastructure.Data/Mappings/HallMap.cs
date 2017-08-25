using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class HallMap : IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder.Property(e => e.Format)
                .IsRequired()
                .HasMaxLength(32);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

            builder.HasOne(d => d.Cinema)
                .WithMany(p => p.Halls)
                .HasForeignKey(d => d.CinemaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Halls_Cinemas");
        }
    }
}