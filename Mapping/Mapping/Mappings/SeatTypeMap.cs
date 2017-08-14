using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class SeatTypeMap : ClassMap<SeatType>
    {
        public SeatTypeMap()
        {
            Id(e => e.Id);

            Map(e => e.Name)
                .Length(64)
                .Not.Nullable()
                .Unique();

            HasMany(e => e.Seats)
                .KeyColumn("SeatTypeId")
                .Inverse()
                .Cascade.All();

            HasMany(e => e.SessionPrices)
                .KeyColumn("SeatTypeId")
                .Inverse()
                .Cascade.All();
        }
    }
}
