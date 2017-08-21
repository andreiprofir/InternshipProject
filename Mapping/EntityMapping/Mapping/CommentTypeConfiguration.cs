using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class CommentTypeConfiguration : EntityTypeConfiguration<Comment>
    {
        public CommentTypeConfiguration()
        {
            Property(e => e.Text)
                .IsRequired()
                .HasMaxLength(1024);

            HasMany(e => e.Answers)
                .WithOptional(e => e.AnswerTo)
                .HasForeignKey(e => e.AnswerToId);
        }
    }
}