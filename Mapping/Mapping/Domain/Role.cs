using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class Role : BaseEntity
    {
        public virtual string Name { get; set; }
        
        public virtual IList<User> Users { get; set; }
    }
}
