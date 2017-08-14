using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class MovieSessionMap : ClassMap<MovieSession>
    {
        public MovieSessionMap()
        {
            Id(e => e.Id);

            Map(e => e.Time)
                .Not.Nullable();

            References(e => e.Hall)
                .Column("HallId")
                .Not.Nullable()
                .Cascade.All();

            References(e => e.Movie)
                .Column("MovieId")
                .Not.Nullable()
                .Cascade.All();

            HasMany(e => e.Orders)
                .KeyColumn("MovieSessionId")
                .Inverse()
                .Cascade.All();

            HasMany(e => e.SessionPrices)
                .KeyColumn("MovieSessionId")
                .Inverse()
                .Cascade.All();
        }
    }
}
