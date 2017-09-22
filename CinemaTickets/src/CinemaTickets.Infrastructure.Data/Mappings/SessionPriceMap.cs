using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class SessionPriceMap : IEntityTypeConfiguration<SessionPrice>
    {
        public void Configure(EntityTypeBuilder<SessionPrice> builder)
        {
            builder.HasIndex(e => new { e.MovieSessionId, e.SeatTypeId })
                .HasName("AK_SessionPrices_MovieSessionId_SeatTypeId")
                .IsUnique();

            builder.Property(e => e.Price)
                .HasColumnType("money")
                .HasDefaultValueSql("(0)");

            builder.HasOne(d => d.MovieSession)
                .WithMany(p => p.SessionPrices)
                .HasForeignKey(d => d.MovieSessionId)
                //.OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SessionPrices_MovieSessions");

            builder.HasOne(d => d.SeatType)
                .WithMany(p => p.SessionPrices)
                .HasForeignKey(d => d.SeatTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SessionPrices_SeatTypes");
        }
    }
}