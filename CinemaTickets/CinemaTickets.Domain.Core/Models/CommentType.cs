using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class CommentType : BaseEntity
    {
        public CommentType()
        {
            Comments = new HashSet<Comment>();
        }

        public string Name { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
