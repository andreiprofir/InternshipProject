using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Models;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class ActorMap : EntityTypeConfiguration<Actor>
    {
        public ActorMap()
        {
            HasMany(e => e.Movies)
                .WithMany(e => e.Actors)
                .Map(m => m.ToTable("MovieActors").MapLeftKey("ActorId").MapRightKey("MovieId"));
        }
    }
}