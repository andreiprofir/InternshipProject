using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Classes
{
    public partial class Entity : BaseEntity
    {
        public Entity()
        {
            Comments = new HashSet<Comment>();
            Pictures = new HashSet<Picture>();
        }

        public virtual Cinema Cinema { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
}
