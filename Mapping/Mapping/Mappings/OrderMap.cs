using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class OrderMap : ClassMap<Order>
    {
        private const string UniqueKeyName = "AK_Order_MovieSession_Seat_User";
        public OrderMap()
        {
            Table("Orders");

            Id(e => e.Id);

            References(e => e.MovieSession)
                .Column("MovieSessionId")
                .Not.Nullable()
                .UniqueKey(UniqueKeyName)
                .Cascade.All();

            References(e => e.Seat)
                .Column("SeatId")
                .Not.Nullable()
                .UniqueKey(UniqueKeyName)
                .Cascade.All();

            References(e => e.User)
                .Column("UserId")
                .Not.Nullable()
                .UniqueKey(UniqueKeyName)
                .Cascade.All();
        }
    }
}
