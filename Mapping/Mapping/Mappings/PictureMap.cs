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

            Map(e => e.Uri);

            Map(e => e.Alt);

            References(e => e.Entity)
                .Column("EntityId")
                .Cascade.All();
        }
    }
}
