using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class ActorMap : ClassMap<Actor>
    {
        public ActorMap()
        {
            Table("Actors");

            Id(e => e.Id);

            Map(e => e.FirstName);

            Map(e => e.LastName);

            HasManyToMany(e => e.Movies)
                .Table("MovieActors")
                .ParentKeyColumn("ActorId")
                .ChildKeyColumn("MovieId")
                .Cascade.All();
        }
    }
}
