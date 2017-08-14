using System;
using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class Entity : BaseEntity
    {  
        public virtual Cinema Cinema { get; set; }
        
        public virtual IList<Comment> Comments { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Movie Movie { get; set; }
        
        public virtual IList<Picture> Pictures { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
}
