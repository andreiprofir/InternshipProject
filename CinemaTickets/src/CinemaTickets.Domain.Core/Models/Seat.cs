using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Seat
    {
        public Seat()
        {
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public bool? IsBusy { get; set; }
        public long HallId { get; set; }
        public long SeatTypeId { get; set; }

        public Hall Hall { get; set; }
        public SeatType SeatType { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
