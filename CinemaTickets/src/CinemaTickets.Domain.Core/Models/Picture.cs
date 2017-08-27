using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Picture
    {
        public long Id { get; set; }
        public string Uri { get; set; }
        public string Alt { get; set; }
        public long EntityId { get; set; }

        public Entity Entity { get; set; }
    }
}
