using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class WriterMap : ClassMap<Writer>
    {
        private const string UniqueKeyName = "AK_Writer_FirstName_LastName";
        public WriterMap()
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
                .ParentKeyColumn("WriterId")
                .ChildKeyColumn("MovieId")
                .Cascade.All()
                .Inverse();
        }
    }
}
