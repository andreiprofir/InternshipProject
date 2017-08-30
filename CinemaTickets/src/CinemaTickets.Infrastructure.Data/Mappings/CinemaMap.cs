using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class CinemaMap : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.ContactPhone)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.Dislikes).HasDefaultValueSql("(0)");

            builder.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.Likes).HasDefaultValueSql("(0)");

            builder.Property(e => e.ShortName)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.Street)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasOne(d => d.City)
                .WithMany(p => p.Cinemas)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cinemas_Cities");

            builder.HasOne(d => d.Entity)
                .WithOne(p => p.Cinemas)
                .HasForeignKey<Cinema>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cinemas_Entities");
        }
    }
}