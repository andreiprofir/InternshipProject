using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Models;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class DirectorMap : EntityTypeConfiguration<Director>
    {
        public DirectorMap()
        {
            HasMany(e => e.Movies)
                .WithMany(e => e.Directors)
                .Map(m => m.ToTable("MovieDirectors").MapLeftKey("DirectorId").MapRightKey("MovieId"));
        }
    }
}