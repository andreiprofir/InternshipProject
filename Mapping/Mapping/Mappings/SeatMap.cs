using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class SeatMap : ClassMap<Seat>
    {
        private const string UniqueKeyName = "AK_Seat_RowNumber_ColumnNumber_Hall";
        public SeatMap()
        {
            Table("Seats");

            Id(e => e.Id);

            Map(e => e.Identifier);

            Map(e => e.RowNumber);

            Map(e => e.ColumnNumber);

            Map(e => e.IsBusy);

            References(e => e.Hall)
                .Column("HallId")
                .Cascade.All();

            HasMany(e => e.Orders)
                .KeyColumn("SeatId")
                .Inverse()
                .Cascade.All();

            References(e => e.SeatType)
                .Column("SeatTypeId")
                .Cascade.All();
        }
    }
}
