using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class GenreMap : ClassMap<Genre>
    {
        public GenreMap()
        {
            Table("Genres");

            Id(e => e.Id)
                .GeneratedBy.Foreign("Entity");

            Map(e => e.Name);

            HasOne(e => e.Entity)
                .Constrained()
                .Cascade.All();

            HasManyToMany(e => e.Movies)
                .Table("MovieGenres")
                .ParentKeyColumn("GenreId")
                .ChildKeyColumn("MovieId")
                .Cascade.All()
                .Inverse();
        }
    }
}
