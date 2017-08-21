using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class CommentMap : ClassMap<Comment>
    {
        public CommentMap()
        {
            Table("Comments");

            Id(e => e.Id);

            References(e => e.User)
                .Column("UserId")
                .Cascade.All();

            Map(e => e.Date);

            Map(e => e.Likes);

            Map(e => e.Text);

            References(e => e.Entity)
                .Column("EntityId")
                .Cascade.All();

            HasMany(e => e.Answers)
                .KeyColumn("AnswerToId")
                .Inverse()
                .Cascade.All();

            References(e => e.AnswerTo)
                .Column("AnswerToId")
                .Cascade.All();

            References(e => e.CommentType)
                .Column("CommentTypeId")
                .Cascade.All();
        }
    }
}
