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
            Table("Cinemas");

            Id(e => e.Id)
                .GeneratedBy.Foreign("Entity");

            Map(e => e.ShortName);

            Map(e => e.FullName);

            Map(e => e.Street);

            Map(e => e.ContactPhone);

            Map(e => e.Info);

            Map(e => e.Likes);

            Map(e => e.Dislikes);

            HasOne(e => e.Entity)
                .Constrained()
                .ForeignKey();

            References(e => e.City)
                .Column("CityId")
                .Cascade.All();

            HasMany(e => e.Halls)
                .KeyColumn("CinemaId")
                .Inverse()
                .Cascade.All();

            HasManyToMany(e => e.Promotions)
                .Table("CinemaPromotions")
                .ParentKeyColumn("CinemaId")
                .ChildKeyColumn("PromotionId")
                .Cascade.All()
                .Inverse();
        }
    }
}
