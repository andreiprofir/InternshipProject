﻿using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Models;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class SeatMap : EntityTypeConfiguration<Seat>
    {
        public SeatMap()
        {
            HasMany(e => e.Orders)
                .WithRequired(e => e.Seat)
                .WillCascadeOnDelete(false);
        }
    }
}