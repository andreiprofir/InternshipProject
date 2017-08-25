using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class SeatMap : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.HasIndex(e => new { e.RowNumber, e.ColumnNumber, e.HallId })
                .HasName("AK_Seats_RowNumber_ColumnNumber_HallId")
                .IsUnique();

            builder.Property(e => e.ColumnNumber).HasDefaultValueSql("((0))");

            builder.Property(e => e.Identifier)
                .IsRequired()
                .HasMaxLength(32);

            builder.Property(e => e.IsBusy).HasDefaultValueSql("((0))");

            builder.Property(e => e.RowNumber).HasDefaultValueSql("((0))");

            builder.HasOne(d => d.Hall)
                .WithMany(p => p.Seats)
                .HasForeignKey(d => d.HallId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Seats_Halls");

            builder.HasOne(d => d.SeatType)
                .WithMany(p => p.Seats)
                .HasForeignKey(d => d.SeatTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Seats_SeatTypes");
        }
    }
}