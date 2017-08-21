using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class HallTypeConfiguration : EntityTypeConfiguration<Hall>
    {
        public HallTypeConfiguration()
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