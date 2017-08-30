using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class MovieMap : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.AgeLimit).HasDefaultValueSql("(0)");

            builder.Property(e => e.Dislikes).HasDefaultValueSql("(0)");

            builder.Property(e => e.Duration).HasDefaultValueSql("(1)");

            builder.Property(e => e.ImdbRaiting).HasMaxLength(255);

            builder.Property(e => e.Likes).HasDefaultValueSql("(0)");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.OriginalName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.Trailer).HasMaxLength(1024);

            builder.HasOne(d => d.Entity)
                .WithOne(p => p.Movies)
                .HasForeignKey<Movie>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movies_Entities");
        }
    }
}