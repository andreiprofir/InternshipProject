using System.Globalization;
using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class SessionPriceMap : ClassMap<SessionPrice>
    {
        private const string UniqueKeyName = "AK_SessionPrice_MovieSession_SeatType";

        public SessionPriceMap()
        {
            Id(e => e.Id);

            References(e => e.MovieSession)
                .Column("MovieSessionId")
                .Not.Nullable()
                .UniqueKey(UniqueKeyName)
                .Cascade.All();

            References(e => e.SeatType)
                .Column("SeatTypeId")
                .Not.Nullable()
                .UniqueKey(UniqueKeyName)
                .Cascade.All();

            Map(e => e.Price)
                .CustomSqlType("money")
                .Not.Nullable()
                .Default("0.0");

            CheckConstraint("Price >= 0");
        }
    }
}
