using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class HallMap : ClassMap<Hall>
    {
        public HallMap()
        {
            Table("Halls");

            Id(e => e.Id);

            Map(e => e.Name);

            Map(e => e.Format);

            References(e => e.Cinema)
                .Column("CinemaId")
                .Cascade.All();

            HasMany(e => e.Seats)
                .KeyColumn("HallId")
                .Inverse()
                .Cascade.All();

            HasManyToMany(e => e.MovieSessions)
                .Table("HallMovieSessions")
                .ParentKeyColumn("HallId")
                .ChildKeyColumn("MovieSessionId")
                .Cascade.All()
                .Inverse();
        }
    }
}
