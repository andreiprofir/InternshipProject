using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Classes;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            HasMany(e => e.Answers)
                .WithOptional(e => e.AnswerTo)
                .HasForeignKey(e => e.AnswerToId);
        }
    }
}