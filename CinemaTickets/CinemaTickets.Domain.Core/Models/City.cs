using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class City : BaseEntity
    {
        public City()
        {
            Cinemas = new HashSet<Cinema>();
        }
        
        public string Name { get; set; }

        public virtual ICollection<Cinema> Cinemas { get; set; }
    }
}
