using System;
using ConsoleApp1.Domain;
using FluentNHibernate.Mapping;

namespace Mapping.Mappings
{
    public class PromotionMap : ClassMap<Promotion>
    {
        public PromotionMap()
        {
            Table("Promotions");

            Id(e => e.Id)
                .GeneratedBy.Foreign("Entity");

            Map(e => e.Title)
                .Length(255)
                .Not.Nullable();

            Map(e => e.ShortDescription)
                .Length(512);

            Map(e => e.DescriptionOfRules)
                .CustomSqlType("NVARCHAR(MAX)");

            Map(e => e.ValidFrom);

            Map(e => e.ValidTo);

            HasOne(e => e.Entity)
                .Constrained().ForeignKey();

            HasManyToMany(e => e.Cinemas)
                .Table("CinemaPromotions")
                .ParentKeyColumn("PromotionId")
                .ChildKeyColumn("CinemaId")
                .Cascade.All();

            HasManyToMany(e => e.Movies)
                .Table("MoviePromotions")
                .ParentKeyColumn("PromotionId")
                .ChildKeyColumn("MovieId")
                .Cascade.All();

            CheckConstraint("ValidFrom < ValidTo");
        }
    }
}
