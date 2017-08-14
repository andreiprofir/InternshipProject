using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class Cinema : BaseEntity
    {
        public virtual string ShortName { get; set; }
        
        public virtual string FullName { get; set; }
        
        public virtual string Street { get; set; }
        
        public virtual string ContactPhone { get; set; }
        
        public virtual string Info { get; set; }

        public virtual int Likes { get; set; }

        public virtual int Dislikes { get; set; }

        public virtual Entity Entity { get; set; }

        public virtual City City { get; set; }
        
        public virtual IList<Hall> Halls { get; set; }

        public virtual IList<Promotion> Promotions { get; set; }
    }
}
