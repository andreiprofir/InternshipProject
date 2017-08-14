using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {
            Id(e => e.Id);

            Map(e => e.Name)
                .Length(64)
                .Not.Nullable()
                .Unique();

            HasManyToMany(e => e.Movies)
                .ParentKeyColumn("CountryId")
                .ChildKeyColumn("MovieId")
                .Cascade.All()
                .Inverse();
        }
    }
}
