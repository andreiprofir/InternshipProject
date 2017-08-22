using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Classes;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class EntityMap : EntityTypeConfiguration<Entity>
    {
        public EntityMap()
        {
            HasOptional(e => e.Cinema)
                .WithRequired(e => e.Entity);

            HasMany(e => e.Comments)
                .WithRequired(e => e.Entity)
                .WillCascadeOnDelete(false);

            HasOptional(e => e.Genre)
                .WithRequired(e => e.Entity)
                .WillCascadeOnDelete(true);

            HasOptional(e => e.Movie)
                .WithRequired(e => e.Entity);

            HasMany(e => e.Pictures)
                .WithRequired(e => e.Entity)
                .WillCascadeOnDelete(false);

            HasOptional(e => e.Promotion)
                .WithRequired(e => e.Entity);
        }
    }
}