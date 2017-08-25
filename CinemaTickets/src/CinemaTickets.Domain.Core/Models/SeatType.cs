using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class SeatType
    {
        public SeatType()
        {
            Seats = new HashSet<Seat>();
            SessionPrices = new HashSet<SessionPrice>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<Seat> Seats { get; set; }
        public ICollection<SessionPrice> SessionPrices { get; set; }
    }
}
