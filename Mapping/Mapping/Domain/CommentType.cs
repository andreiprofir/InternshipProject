using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class CommentType : BaseEntity
    {
        public virtual string Name { get; set; }
        
        public virtual IList<Comment> Comments { get; set; }
    }
}
