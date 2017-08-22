using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class SeatType : BaseEntity
    {
        public SeatType()
        {
            Seats = new HashSet<Seat>();
            SessionPrices = new HashSet<SessionPrice>();
        }
        
        public string Name { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }

        public virtual ICollection<SessionPrice> SessionPrices { get; set; }
    }
}
