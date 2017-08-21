using System.Collections.Generic;

namespace EntityMapping
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

        public virtual ICollection<Seat> Seats { get; set; }

        public virtual ICollection<SessionPrice> SessionPrices { get; set; }
    }
}
