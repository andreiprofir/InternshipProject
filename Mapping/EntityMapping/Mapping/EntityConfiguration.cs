using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class EntityConfiguration : EntityTypeConfiguration<Entity>
    {
        public EntityConfiguration()
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