using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class CityMap : ClassMap<City>
    {
        public CityMap()
        {
            Id(e => e.Id);

            Map(e => e.Name)
                .Length(64)
                .Not.Nullable()
                .Unique();

            HasMany(e => e.Cinemas)
                .KeyColumn("CityId")
                .Inverse()
                .Cascade.All();
        }
    }
}
