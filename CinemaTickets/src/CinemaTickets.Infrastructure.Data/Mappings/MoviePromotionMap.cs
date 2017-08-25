using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class MoviePromotionMap : IEntityTypeConfiguration<MoviePromotion>
    {
        public void Configure(EntityTypeBuilder<MoviePromotion> builder)
        {
            builder.HasKey(e => new { e.MovieId, e.PromotionId });

            builder.HasOne(d => d.Movie)
                .WithMany(p => p.MoviePromotions)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK_MoviePromotions_Movies");

            builder.HasOne(d => d.Promotion)
                .WithMany(p => p.MoviePromotions)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("FK_MoviePromotions_Promotions");
        }
    }
}