using System.Collections.Generic;

namespace EntityMapping
{
    public partial class Hall
    {
        public Hall()
        {
            MovieSessions = new HashSet<MovieSession>();
            Seats = new HashSet<Seat>();
            MovieSessions1 = new HashSet<MovieSession>();
        }

        public long Id { get; set; }
        
        public string Name { get; set; }
        
        public string Format { get; set; }

        public long CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }

        public virtual ICollection<MovieSession> MovieSessions { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }

        public virtual ICollection<MovieSession> MovieSessions1 { get; set; }
    }
}
