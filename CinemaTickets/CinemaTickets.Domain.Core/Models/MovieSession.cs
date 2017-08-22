using System;
using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class MovieSession : BaseEntity
    {
        public MovieSession()
        {
            Orders = new HashSet<Order>();
            SessionPrices = new HashSet<SessionPrice>();
        }

        public DateTimeOffset Time { get; set; }

        public long HallId { get; set; }

        public long MovieId { get; set; }

        public virtual Hall Hall { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<SessionPrice> SessionPrices { get; set; }
    }
}
