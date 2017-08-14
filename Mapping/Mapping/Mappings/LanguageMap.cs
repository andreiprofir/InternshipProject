using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class LanguageMap : ClassMap<Language>
    {
        public LanguageMap()
        {
            Id(e => e.Id);

            Map(e => e.Name)
                .Not.Nullable()
                .Unique();

            HasManyToMany(e => e.Movies)
                .ParentKeyColumn("LanguageId")
                .ChildKeyColumn("MovieId")
                .Cascade.All()
                .Inverse();
        }
    }
}
