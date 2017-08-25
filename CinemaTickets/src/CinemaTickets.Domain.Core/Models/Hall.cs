using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Hall
    {
        public Hall()
        {
            MovieSessions = new HashSet<MovieSession>();
            Seats = new HashSet<Seat>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Format { get; set; }
        public long CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public ICollection<MovieSession> MovieSessions { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
