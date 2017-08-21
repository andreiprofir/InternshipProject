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
            Table("SessionPrices");

            Id(e => e.Id);

            References(e => e.MovieSession)
                .Column("MovieSessionId")
                .Cascade.All();

            References(e => e.SeatType)
                .Column("SeatTypeId")
                .Cascade.All();

            Map(e => e.Price)
                .CustomSqlType("money");
        }
    }
}
