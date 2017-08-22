using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Models;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class HallMap : EntityTypeConfiguration<Hall>
    {
        public HallMap()
        {
            HasMany(e => e.MovieSessions)
                .WithRequired(e => e.Hall)
                .HasForeignKey(e => e.HallId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.Seats)
                .WithRequired(e => e.Hall)
                .WillCascadeOnDelete(false);
        }
    }
}