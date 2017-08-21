using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class MovieSessionMap : ClassMap<MovieSession>
    {
        public MovieSessionMap()
        {
            Table("MovieSessions");

            Id(e => e.Id);

            Map(e => e.Time);

            References(e => e.Hall)
                .Column("HallId")
                .Cascade.All();

            References(e => e.Movie)
                .Column("MovieId")
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
