using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(e => e.Email)
                .HasName("AK_Users_Email")
                .IsUnique();

            builder.HasIndex(e => e.PhoneNumber)
                .HasName("AK_PhoneNumber")
                .IsUnique();

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.FirstName).HasMaxLength(64);

            builder.Property(e => e.LastName).HasMaxLength(64);

            builder.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.PhoneNumber).HasMaxLength(255);

            builder.Property(e => e.Salt)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasOne(d => d.Avatar)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.AvatarId)
                .HasConstraintName("FK_Users_Pictures");
        }
    }
}