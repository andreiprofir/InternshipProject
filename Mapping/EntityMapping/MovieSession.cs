using System;
using System.Collections.Generic;

namespace EntityMapping
{
    public partial class MovieSession
    {
        public MovieSession()
        {
            Orders = new HashSet<Order>();
            SessionPrices = new HashSet<SessionPrice>();
            Halls = new HashSet<Hall>();
        }

        public long Id { get; set; }

        public DateTimeOffset Time { get; set; }

        public long HallId { get; set; }

        public long MovieId { get; set; }

        public virtual Hall Hall { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<SessionPrice> SessionPrices { get; set; }

        public virtual ICollection<Hall> Halls { get; set; }
    }
}
