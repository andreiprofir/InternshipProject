using System;
using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class CinemaMap : ClassMap<Cinema>
    {
        private const int DefaultValueFromLikes = 0;
        public CinemaMap()
        {
            Id(e => e.Id)
                .GeneratedBy.Foreign("Entity");

            Map(e => e.ShortName)
                .Length(128)
                .Not.Nullable();

            Map(e => e.FullName)
                .Length(255)
                .Not.Nullable();

            Map(e => e.Street)
                .Length(255)
                .Not.Nullable();

            Map(e => e.ContactPhone)
                .Length(128)
                .Not.Nullable();

            Map(e => e.Info)
                .CustomSqlType("NVARCHAR(MAX)");

            Map(e => e.Likes)
                .Not.Nullable()
                .Default(DefaultValueFromLikes.ToString());

            Map(e => e.Dislikes)
                .Not.Nullable()
                .Default(DefaultValueFromLikes.ToString());

            HasOne(e => e.Entity)
                .Constrained()
                .ForeignKey();

            References(e => e.City)
                .Column("CityId")
                .Not.Nullable()
                .Cascade.All();

            HasMany(e => e.Halls)
                .KeyColumn("CinemaId")
                .Not.KeyNullable()
                .Inverse()
                .Cascade.All();

            HasManyToMany(e => e.Promotions)
                .ParentKeyColumn("CinemaId")
                .ChildKeyColumn("PromotionId")
                .Cascade.All()
                .Inverse();

            CheckConstraint("Likes >= 0 AND Dislikes >= 0");
        }
    }
}
