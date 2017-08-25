using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class City
    {
        public City()
        {
            Cinemas = new HashSet<Cinema>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<Cinema> Cinemas { get; set; }
    }
}
