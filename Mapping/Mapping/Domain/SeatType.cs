using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class SeatType : BaseEntity
    {
        public virtual string Name { get; set; }
        
        public virtual IList<Seat> Seats { get; set; }
        
        public virtual IList<SessionPrice> SessionPrices { get; set; }
    }
}
