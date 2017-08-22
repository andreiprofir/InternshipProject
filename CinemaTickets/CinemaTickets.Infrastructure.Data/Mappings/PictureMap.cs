using System.Data.Entity.ModelConfiguration;
using CinemaTickets.Domain.Core.Models;

namespace CinemaTickets.Infrastructure.Data.Mappings
{
    public class PictureMap : EntityTypeConfiguration<Picture>
    {
        public PictureMap()
        {
            HasMany(e => e.Users)
                .WithOptional(e => e.Picture)
                .HasForeignKey(e => e.AvatarId);
        }
    }
}