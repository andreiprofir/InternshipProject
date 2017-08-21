using System.Collections.Generic;

namespace EntityMapping
{
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
