using System.Collections.Generic;

namespace EntityMapping
{
    public partial class Picture
    {
        public Picture()
        {
            Users = new HashSet<User>();
        }

        public long Id { get; set; }
        
        public string Uri { get; set; }
        
        public string Alt { get; set; }

        public long EntityId { get; set; }

        public virtual Entity Entity { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
