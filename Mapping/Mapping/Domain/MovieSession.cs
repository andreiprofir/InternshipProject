using System;
using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class MovieSession : BaseEntity
    {
        public virtual DateTimeOffset Time { get; set; }

        public virtual Hall Hall { get; set; }

        public virtual Movie Movie { get; set; }
        
        public virtual IList<Order> Orders { get; set; }
        
        public virtual IList<SessionPrice> SessionPrices { get; set; }
    }
}
