using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class CommentTypeMap : ClassMap<CommentType>
    {
        public CommentTypeMap()
        {
            Table("CommentTypes");

            Id(e => e.Id);

            Map(e => e.Name)
                .Length(32)
                .Not.Nullable()
                .Unique();

            HasMany(e => e.Comments)
                .KeyColumn("CommentTypeId")
                .Inverse()
                .Cascade.All();
        }
    }
}
