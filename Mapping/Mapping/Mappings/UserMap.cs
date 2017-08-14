using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(e => e.Id);

            Map(e => e.FirstName)
                .Length(64);

            Map(e => e.LastName)
                .Length(64);

            Map(e => e.Email)
                .Not.Nullable()
                .Unique();

            Map(e => e.Password)
                .Length(128)
                .Not.Nullable();

            Map(e => e.Salt)
                .Not.Nullable();

            Map(e => e.PhoneNumber)
                .Unique();

            References(e => e.Avatar)
                .Column("AvatarId")
                .Cascade.All();

            HasManyToMany(e => e.Roles)
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
