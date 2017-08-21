using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class MovieMap : ClassMap<Movie>
    {
        public MovieMap()
        {
            Table("Movies");

            Id(e => e.Id)
                .GeneratedBy.Foreign("Entity");

            Map(e => e.Name);

            Map(e => e.OriginalName);

            Map(e => e.Trailer);

            Map(e => e.Duration);

            Map(e => e.ReleaseDate);

            Map(e => e.AgeLimit);

            Map(e => e.ImdbRaiting);

            Map(e => e.Description);

            Map(e => e.Likes);

            Map(e => e.Dislikes);

            HasOne(e => e.Entity)
                .Constrained()
                .ForeignKey();

            HasMany(e => e.MovieSessions)
                .KeyColumn("MovieId")
                .Inverse()
                .Cascade.All();

            HasManyToMany(e => e.Directors)
                .Table("MovieDirectors")
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("DirectorId")
                .Cascade.All();

            HasManyToMany(e => e.Genres)
                .Table("MovieGenres")
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("GenreId")
                .Cascade.All();

            HasManyToMany(e => e.Promotions)
                .Table("MoviePromotions")
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("PromotionId")
                .Cascade.All();

            HasManyToMany(e => e.Actors)
                .Table("MovieActors")
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("ActorId")
                .Cascade.All();

            HasManyToMany(e => e.Countries)
                .Table("MovieCountries")
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("CountryId")
                .Cascade.All();

            HasManyToMany(e => e.Languages)
                .Table("MovieLanguages")
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("LanguageId")
                .Cascade.All();

            HasManyToMany(e => e.Writers)
                .Table("MovieWriters")
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("WriterId")
                .Cascade.All();
        }
    }
}
