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
                .Index("PK_Genres")
                .GeneratedBy.Foreign("Entity");

            Map(e => e.Name)
                .Length(128)
                .Not.Nullable()
                .Unique();

            HasOne(e => e.Entity)
                .Constrained()
                .ForeignKey("FK_Genres_Entities")
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
