using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class CinemaPromotionMap : IEntityTypeConfiguration<CinemaPromotion>
    {
        public void Configure(EntityTypeBuilder<CinemaPromotion> builder)
        {
            builder.HasKey(e => new { e.CinemaId, e.PromotionId });

            builder.HasOne(d => d.Cinema)
                .WithMany(p => p.CinemaPromotions)
                .HasForeignKey(d => d.CinemaId)
                .HasConstraintName("FK_CinemaPromotions_Cinemas");

            builder.HasOne(d => d.Promotion)
                .WithMany(p => p.CinemaPromotions)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("FK_CinemaPromotions_Promotions");
        }
    }
}