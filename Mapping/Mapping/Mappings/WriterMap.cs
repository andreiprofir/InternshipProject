using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class WriterMap : ClassMap<Writer>
    {
        private const string UniqueKeyName = "AK_Writer_FirstName_LastName";
        public WriterMap()
        {
            Table("Writers");

            Id(e => e.Id);

            Map(e => e.FirstName);

            Map(e => e.LastName);

            HasManyToMany(e => e.Movies)
                .Table("MovieWriters")
                .ParentKeyColumn("WriterId")
                .ChildKeyColumn("MovieId")
                .Cascade.All()
                .Inverse();
        }
    }
}
