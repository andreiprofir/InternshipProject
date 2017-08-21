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

            Map(e => e.Name);

            HasMany(e => e.Comments)
                .KeyColumn("CommentTypeId")
                .Inverse()
                .Cascade.All();
        }
    }
}
