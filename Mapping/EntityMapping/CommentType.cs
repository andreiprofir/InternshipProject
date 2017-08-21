namespace EntityMapping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CommentType
    {
        public CommentType()
        {
            Comments = new HashSet<Comment>();
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
