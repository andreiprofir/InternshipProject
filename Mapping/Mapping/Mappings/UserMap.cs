using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");

            Id(e => e.Id);

            Map(e => e.FirstName);

            Map(e => e.LastName);

            Map(e => e.Email);

            Map(e => e.Password);

            Map(e => e.Salt);

            Map(e => e.PhoneNumber);

            References(e => e.Avatar)
                .Column("AvatarId")
                .Cascade.All();

            HasManyToMany(e => e.Roles)
                .Table("UserRoles")
                .ParentKeyColumn("UserId")
                .ChildKeyColumn("RoleId")
                .Cascade.All();

            HasMany(e => e.Orders)
                .KeyColumn("UserId")
                .Inverse()
                .Cascade.All();
        }
    }
}
