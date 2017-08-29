using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Genre
    {
        public Genre()
        {
            MovieGenres = new HashSet<MovieGenre>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public Entity IdNavigation { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
