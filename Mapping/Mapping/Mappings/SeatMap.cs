using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class SeatMap : ClassMap<Seat>
    {
        private const string UniqueKeyName = "AK_Seat_RowNumber_ColumnNumber_Hall";
        public SeatMap()
        {
            Id(e => e.Id);

            Map(e => e.Identifier)
                .Length(32)
                .Not.Nullable();

            Map(e => e.RowNumber)
                .Not.Nullable()
                .UniqueKey(UniqueKeyName)
                .Default("0");

            Map(e => e.ColumnNumber)
                .Not.Nullable()
                .UniqueKey(UniqueKeyName)
                .Default("0");

            Map(e => e.IsBusy)
                .Default("0")
                .Not.Nullable();

            References(e => e.Hall)
                .Column("HallId")
                .Not.Nullable()
                .UniqueKey(UniqueKeyName)
                .Cascade.All();

            HasMany(e => e.Orders)
                .KeyColumn("SeatId")
                .Inverse()
                .Cascade.All();

            References(e => e.SeatType)
                .Column("SeatTypeId")
                .Not.Nullable()
                .Cascade.All();

            CheckConstraint("RowNumber >= 0 AND ColumnNumber >= 0");
        }
    }
}
