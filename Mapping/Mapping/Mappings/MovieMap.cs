using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class MovieMap : ClassMap<Movie>
    {
        public MovieMap()
        {
            Id(e => e.Id)
                .GeneratedBy.Foreign("Entity");

            Map(e => e.Name)
                .Length(255)
                .Not.Nullable();

            Map(e => e.OriginalName)
                .Length(255)
                .Not.Nullable();

            Map(e => e.Trailer)
                .Length(1024);

            Map(e => e.Duration)
                .Not.Nullable()
                .Default("1")
                .Check("Duration >= 1");

            Map(e => e.ReleaseDate)
                .Not.Nullable();

            Map(e => e.AgeLimit)
                .Default("0")
                .Not.Nullable()
                .Check("AgeLimit >= 0");

            Map(e => e.ImdbRaiting)
                .Length(255);

            Map(e => e.Description)
                .CustomSqlType("NVARCHAR(MAX)");

            Map(e => e.Likes)
                .Not.Nullable()
                .Default("0");

            Map(e => e.Dislikes)
                .Not.Nullable()
                .Default("0");

            HasOne(e => e.Entity)
                .Constrained()
                .ForeignKey();

            HasMany(e => e.MovieSessions)
                .KeyColumn("MovieId")
                .Inverse()
                .Cascade.All();

            HasManyToMany(e => e.Directors)
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("DirectorId")
                .Cascade.All();

            HasManyToMany(e => e.Genres)
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("GenreId")
                .Cascade.All();

            HasManyToMany(e => e.Promotions)
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("PromotionId")
                .Cascade.All();

            HasManyToMany(e => e.Actors)
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("ActorId")
                .Cascade.All();

            HasManyToMany(e => e.Countries)
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("CountryId")
                .Cascade.All();

            HasManyToMany(e => e.Languages)
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("LanguageId")
                .Cascade.All();

            HasManyToMany(e => e.Writers)
                .ParentKeyColumn("MovieId")
                .ChildKeyColumn("WriterId")
                .Cascade.All();
            
            CheckConstraint("Likes >= 0 AND Dislikes >= 0");
        }
    }
}
