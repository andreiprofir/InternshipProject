using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Mapping
{
    public class ActorTypeConfiguration : EntityTypeConfiguration<Actor>
    {
        public ActorTypeConfiguration()
        {
            HasMany(e => e.Movies)
                .WithMany(e => e.Actors)
                .Map(m => m.ToTable("MovieActors").MapLeftKey("ActorId").MapRightKey("MovieId"));
        }
    }
}