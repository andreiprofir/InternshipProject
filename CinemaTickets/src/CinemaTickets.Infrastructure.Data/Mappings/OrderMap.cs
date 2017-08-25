﻿using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasIndex(e => new { e.MovieSessionId, e.SeatId, e.UserId })
                .HasName("AK_Orders_MovieSessionId_SeatId_UserId")
                .IsUnique();

            builder.HasOne(d => d.MovieSession)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.MovieSessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_MovieSessions");

            builder.HasOne(d => d.Seat)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.SeatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Seats");

            builder.HasOne(d => d.User)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Users");
        }
    }
}