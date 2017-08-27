using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Picture
    {
        public Picture()
        {
            Customers = new HashSet<Customer>();
        }

        public long Id { get; set; }
        public string Uri { get; set; }
        public string Alt { get; set; }
        public long EntityId { get; set; }

        public Entity Entity { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
