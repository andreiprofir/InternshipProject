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

            Map(e => e.Name)
                .Length(128)
                .Not.Nullable();

            Map(e => e.Format)
                .Length(32)
                .Not.Nullable();

            References(e => e.Cinema)
                .Column("CinemaId")
                .Not.Nullable()
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
