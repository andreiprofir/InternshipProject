using CinemaTickets.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(e => e.Likes).HasDefaultValueSql("((0))");

            builder.Property(e => e.Text)
                .IsRequired()
                .HasMaxLength(1024);

            builder.HasOne(d => d.AnswerTo)
                .WithMany(p => p.InverseAnswerTo)
                .HasForeignKey(d => d.AnswerToId)
                .HasConstraintName("FK_Comments_Comments");

            builder.HasOne(d => d.CommentType)
                .WithMany(p => p.Comments)
                .HasForeignKey(d => d.CommentTypeId)
                .HasConstraintName("FK_Comments_CommentTypes");

            builder.HasOne(d => d.Entity)
                .WithMany(p => p.Comments)
                .HasForeignKey(d => d.EntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comments_Entities");

            builder.HasOne(d => d.User)
                .WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comments_Users");
        }
    }
}