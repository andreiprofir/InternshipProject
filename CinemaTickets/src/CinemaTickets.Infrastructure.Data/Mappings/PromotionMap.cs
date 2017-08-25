using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class PromotionMap : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.ShortDescription).HasMaxLength(512);

            builder.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasOne(d => d.IdNavigation)
                .WithOne(p => p.Promotions)
                .HasForeignKey<Promotion>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Promotions_Entities");
        }
    }
}