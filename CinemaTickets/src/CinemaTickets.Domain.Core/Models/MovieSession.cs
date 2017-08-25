using System;
using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class MovieSession
    {
        public MovieSession()
        {
            Orders = new HashSet<Order>();
            SessionPrices = new HashSet<SessionPrice>();
        }

        public long Id { get; set; }
        public DateTimeOffset Time { get; set; }
        public long HallId { get; set; }
        public long MovieId { get; set; }

        public Hall Hall { get; set; }
        public Movie Movie { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<SessionPrice> SessionPrices { get; set; }
    }
}
