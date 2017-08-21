using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class PictureMap : ClassMap<Picture>
    {
        public PictureMap()
        {
            Table("Pictures");

            Id(e => e.Id);

            Map(e => e.Uri)
                .Length(1024)
                .Not.Nullable()
                .Unique();

            Map(e => e.Alt)
                .Length(255);

            References(e => e.Entity)
                .Column("EntityId")
                .Not.Nullable()
                .Cascade.All();
        }
    }
}
