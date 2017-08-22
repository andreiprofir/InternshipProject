using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Hall : BaseEntity
    {
        public Hall()
        {
            MovieSessions = new HashSet<MovieSession>();
            Seats = new HashSet<Seat>();
        }
        
        public string Name { get; set; }
        
        public string Format { get; set; }

        public long CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }

        public virtual ICollection<MovieSession> MovieSessions { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }
    }
}
