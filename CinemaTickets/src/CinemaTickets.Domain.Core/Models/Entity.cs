using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Entity
    {
        public Entity()
        {
            Comments = new HashSet<Comment>();
            Pictures = new HashSet<Picture>();
        }

        public long Id { get; set; }

        public Cinema Cinemas { get; set; }
        public Genre Genres { get; set; }
        public Movie Movies { get; set; }
        public Promotion Promotions { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Picture> Pictures { get; set; }
    }
}
