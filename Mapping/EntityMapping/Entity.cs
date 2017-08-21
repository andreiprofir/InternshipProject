using System.Collections.Generic;

namespace EntityMapping
{
    public partial class Entity
    {
        public Entity()
        {
            Comments = new HashSet<Comment>();
            Pictures = new HashSet<Picture>();
        }

        public long Id { get; set; }

        public virtual Cinema Cinema { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
}
