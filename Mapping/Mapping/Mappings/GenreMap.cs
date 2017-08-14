using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class GenreMap : ClassMap<Genre>
    {
        public GenreMap()
        {
            Id(e => e.Id)
                .GeneratedBy.Foreign("Entity");

            Map(e => e.Name)
                .Length(128)
                .Not.Nullable()
                .Unique();

            HasOne(e => e.Entity)
                .Constrained()
                .ForeignKey();

            HasManyToMany(e => e.Movies)
                .ParentKeyColumn("GenreId")
                .ChildKeyColumn("MovieId")
                .Cascade.All()
                .Inverse();
        }
    }
}
