using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class Hall : BaseEntity
    {
        public virtual string Name { get; set; }
        
        public virtual string Format { get; set; }

        public virtual Cinema Cinema { get; set; }
        
        public virtual IList<Seat> Seats { get; set; }
        
        public virtual IList<MovieSession> MovieSessions { get; set; }
    }
}
