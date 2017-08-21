using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class ActorMap : ClassMap<Actor>
    {
        public ActorMap()
        {
            Table("Actors");

            Id(e => e.Id)
                .Index("PK_Actors");

            Map(e => e.FirstName)
                .Length(64)
                .Not.Nullable()
                .UniqueKey("AK_Actors_FirstName_LastName");

            Map(e => e.LastName)
                .Length(64)
                .Not.Nullable()
                .UniqueKey("AK_Actors_FirstName_LastName");

            HasManyToMany(e => e.Movies)
                .Table("MovieActors")
                .ParentKeyColumn("ActorId")
                .ChildKeyColumn("MovieId")
                .ForeignKeyConstraintNames("FK_MovieActors_Actors", "FK_MovieActors_Movies")
                .Cascade.All();
        }
    }
}
