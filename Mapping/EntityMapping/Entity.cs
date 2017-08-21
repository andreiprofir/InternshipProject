namespace EntityMapping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
