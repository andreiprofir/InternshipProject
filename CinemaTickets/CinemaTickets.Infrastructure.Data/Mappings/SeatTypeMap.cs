using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Models;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class SeatTypeMap : EntityTypeConfiguration<SeatType>
    {
        public SeatTypeMap()
        {
            HasMany(e => e.Seats)
                .WithRequired(e => e.SeatType)
                .WillCascadeOnDelete(false);

            HasMany(e => e.SessionPrices)
                .WithRequired(e => e.SeatType)
                .WillCascadeOnDelete(false);
        }
    }
}