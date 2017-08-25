using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class PictureMap : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.HasIndex(e => e.Uri)
                .HasName("AK_Pictures_Uri")
                .IsUnique();

            builder.Property(e => e.Alt).HasMaxLength(255);

            builder.Property(e => e.Uri)
                .IsRequired()
                .HasMaxLength(1024);

            builder.HasOne(d => d.Entity)
                .WithMany(p => p.Pictures)
                .HasForeignKey(d => d.EntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pictures_Entities");
        }
    }
}