using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Classes;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class LanguageMap : EntityTypeConfiguration<Language>
    {
        public LanguageMap()
        {
            HasMany(e => e.Movies)
                .WithMany(e => e.Languages)
                .Map(m => m.ToTable("MovieLanguages").MapLeftKey("LanguageId").MapRightKey("MovieId"));
        }
    }
}