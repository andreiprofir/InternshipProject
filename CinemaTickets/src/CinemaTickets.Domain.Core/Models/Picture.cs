using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
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

        public Entity Entity { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
