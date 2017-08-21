using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class DirectorMap : ClassMap<Director>
    {
        private const string UniqueKeyName = "AK_Director_FirstName_LastName";
        public DirectorMap()
        {
            Table("Directors");

            Id(e => e.Id);

            Map(e => e.FirstName);

            Map(e => e.LastName);

            HasManyToMany(e => e.Movies)
                .Table("MovieDirectors")
                .ParentKeyColumn("DirectorId")
                .ChildKeyColumn("MovieId")
                .Cascade.All()
                .Inverse();
        }
    }
}
