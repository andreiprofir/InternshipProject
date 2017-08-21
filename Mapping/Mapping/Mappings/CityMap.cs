using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class CityMap : ClassMap<City>
    {
        public CityMap()
        {
            Table("Cities");

            Id(e => e.Id);

            Map(e => e.Name);

            HasMany(e => e.Cinemas)
                .KeyColumn("CityId")
                .Inverse()
                .Cascade.All();
        }
    }
}
