using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class RoleMap : ClassMap<Role>
    {
        public RoleMap()
        {
            Table("Roles");

            Id(e => e.Id);

            Map(e => e.Name)
                .Length(255)
                .Not.Nullable()
                .Unique();

            HasManyToMany(e => e.Users)
                .Table("UserRoles")
                .ParentKeyColumn("RoleId")
                .ChildKeyColumn("UserId")
                .Cascade.All()
                .Inverse();
        }
    }
}
