using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");

            Id(e => e.Id)
                .Index("PK_Users");

            Map(e => e.FirstName)
                .Length(64);

            Map(e => e.LastName)
                .Length(64);

            Map(e => e.Email)
                .Not.Nullable()
                .UniqueKey("AK_Users_Email");

            Map(e => e.Password)
                .Length(128)
                .Not.Nullable();

            Map(e => e.Salt)
                .Not.Nullable();

            Map(e => e.PhoneNumber)
                .UniqueKey("AK_PhoneNumber");

            References(e => e.Avatar)
                .ForeignKey("FK_Users_Pictures")
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
