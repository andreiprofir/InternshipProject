using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class EntityMap : ClassMap<Entity>
    {
        public EntityMap()
        {
            Table("Entities");

            Id(e => e.Id)
                .Index("PK_Entities");

            HasOne(e => e.Cinema)
                .Cascade.All();

            HasMany(e => e.Comments)
                .KeyColumn("EntityId")
                .Inverse()
                .Cascade.All();

            HasOne(e => e.Genre)
                .Cascade.All();

            HasOne(e => e.Movie)
                .Cascade.All();

            HasMany(e => e.Pictures)
                .KeyColumn("EntityId")
                .Inverse()
                .Cascade.All();

            HasOne(e => e.Promotion)
                .Cascade.All();
        }
    }
}
