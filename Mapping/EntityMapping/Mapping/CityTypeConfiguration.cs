using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class CityTypeConfiguration : EntityTypeConfiguration<City>
    {
        public CityTypeConfiguration()
        {
            HasMany(e => e.Cinemas)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);
        }
    }
}