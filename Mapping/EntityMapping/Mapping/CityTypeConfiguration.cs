using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class CityTypeConfiguration : EntityTypeConfiguration<City>
    {
        public CityTypeConfiguration()
        {
            Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(64);

            HasMany(e => e.Cinemas)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);
        }
    }
}