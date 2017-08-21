using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class CinemaTypeConfiguration : EntityTypeConfiguration<Cinema>
    {
        public CinemaTypeConfiguration()
        {
            HasMany(e => e.Halls)
                .WithRequired(e => e.Cinema)
                .WillCascadeOnDelete(false);

            HasMany(e => e.Promotions)
                .WithMany(e => e.Cinemas)
                .Map(m => m.ToTable("CinemaPromotions").MapLeftKey("CinemaId").MapRightKey("PromotionId"));
        }
    }
}