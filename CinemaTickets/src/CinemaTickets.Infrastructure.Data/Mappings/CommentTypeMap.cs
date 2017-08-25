using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class CommentTypeMap : IEntityTypeConfiguration<CommentType>
    {
        public void Configure(EntityTypeBuilder<CommentType> builder)
        {
            builder.HasIndex(e => e.Name)
                .HasName("AK_CommentTypes_Name")
                .IsUnique();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(32);
        }
    }
}