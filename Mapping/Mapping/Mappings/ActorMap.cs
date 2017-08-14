using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class ActorMap : ClassMap<Actor>
    {
        private const string UniqueKeyName = "AK_Actor_FirstName_LastName";

        public ActorMap()
        {
            Id(e => e.Id);

            Map(e => e.FirstName)
                .Length(64)
                .Not.Nullable()
                .UniqueKey(UniqueKeyName);

            Map(e => e.LastName)
                .Length(64)
                .Not.Nullable()
                .UniqueKey(UniqueKeyName);

            HasManyToMany(e => e.Movies)
                .ParentKeyColumn("ActorId")
                .ChildKeyColumn("MovieId")
                .Cascade.All();
        }
    }
}
