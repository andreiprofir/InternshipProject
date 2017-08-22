using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Classes
{
    public partial class Picture : BaseEntity
    {
        public Picture()
        {
            Users = new HashSet<User>();
        }
        
        public string Uri { get; set; }
        
        public string Alt { get; set; }

        public long EntityId { get; set; }

        public virtual Entity Entity { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
