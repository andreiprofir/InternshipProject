using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class LanguageMap : ClassMap<Language>
    {
        public LanguageMap()
        {
            Table("Languages");

            Id(e => e.Id);

            Map(e => e.Name);

            HasManyToMany(e => e.Movies)
                .Table("MovieLanguages")
                .ParentKeyColumn("LanguageId")
                .ChildKeyColumn("MovieId")
                .Cascade.All()
                .Inverse();
        }
    }
}
