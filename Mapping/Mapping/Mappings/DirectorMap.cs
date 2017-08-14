using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class DirectorMap : ClassMap<Director>
    {
        private const string UniqueKeyName = "AK_Director_FirstName_LastName";
        public DirectorMap()
        {
            Id(e => e.Id);

            Map(e => e.FirstName)
                .Length(64)
                .Not.Nullable()
                .UniqueKey(UniqueKeyName);

            Map(e => e.LastName)
                .Length(64)
                .Not.Nullable()
                .UniqueKey(UniqueKeyName);

            HasManyToMany(e => e.Movies)
                .ParentKeyColumn("DirectorId")
                .ChildKeyColumn("MovieId")
                .Cascade.All()
                .Inverse();
        }
    }
}
