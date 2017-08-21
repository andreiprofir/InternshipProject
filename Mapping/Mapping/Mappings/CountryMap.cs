using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {
            Table("Countries");

            Id(e => e.Id);

            Map(e => e.Name);

            HasManyToMany(e => e.Movies)
                .Table("MovieCountries")
                .ParentKeyColumn("CountryId")
                .ChildKeyColumn("MovieId")
                .Cascade.All()
                .Inverse();
        }
    }
}
