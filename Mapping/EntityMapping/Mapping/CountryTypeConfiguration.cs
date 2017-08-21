using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class CountryTypeConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryTypeConfiguration()
        {
            HasMany(e => e.Movies)
                .WithMany(e => e.Countries)
                .Map(m => m.ToTable("MovieCountries").MapLeftKey("CountryId").MapRightKey("MovieId"));
        }
    }
}