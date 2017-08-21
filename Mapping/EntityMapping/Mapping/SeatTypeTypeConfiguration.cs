using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class SeatTypeTypeConfiguration : EntityTypeConfiguration<SeatType>
    {
        public SeatTypeTypeConfiguration()
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