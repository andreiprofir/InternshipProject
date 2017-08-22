using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Classes;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class SessionPriceMap : EntityTypeConfiguration<SessionPrice>
    {
        public SessionPriceMap()
        {
            Property(e => e.Price)
                .HasColumnType("money")
                .HasPrecision(19, 4);
        }
    }
}