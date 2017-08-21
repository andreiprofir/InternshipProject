using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class SeatTypeConfiguration : EntityTypeConfiguration<Seat>
    {
        public SeatTypeConfiguration()
        {
            HasMany(e => e.Orders)
                .WithRequired(e => e.Seat)
                .WillCascadeOnDelete(false);
        }
    }
}