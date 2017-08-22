using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Classes;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class CinemaMap : EntityTypeConfiguration<Cinema>
    {
        public CinemaMap()
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