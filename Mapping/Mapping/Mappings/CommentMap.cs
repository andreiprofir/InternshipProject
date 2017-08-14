using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class CommentMap : ClassMap<Comment>
    {
        public CommentMap()
        {
            Id(e => e.Id);

            References(e => e.User)
                .Column("UserId")
                .Not.Nullable()
                .Cascade.All();

            Map(e => e.Date)
                .Not.Nullable();

            Map(e => e.Likes)
                .Not.Nullable()
                .Default("0");

            Map(e => e.Text)
                .Length(1024)
                .Not.Nullable();

            References(e => e.Entity)
                .Column("EntityId")
                .Not.Nullable()
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
