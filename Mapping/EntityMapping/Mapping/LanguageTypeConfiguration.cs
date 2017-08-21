using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class LanguageTypeConfiguration : EntityTypeConfiguration<Language>
    {
        public LanguageTypeConfiguration()
        {
            HasMany(e => e.Movies)
                .WithMany(e => e.Languages)
                .Map(m => m.ToTable("MovieLanguages").MapLeftKey("LanguageId").MapRightKey("MovieId"));
        }
    }
}