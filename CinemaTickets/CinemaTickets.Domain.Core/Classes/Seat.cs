using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Classes
{
    public partial class Seat : BaseEntity
    {
        public Seat()
        {
            Orders = new HashSet<Order>();
        }
        
        public string Identifier { get; set; }

        public int RowNumber { get; set; }

        public int ColumnNumber { get; set; }

        public bool IsBusy { get; set; }

        public long HallId { get; set; }

        public long SeatTypeId { get; set; }

        public virtual Hall Hall { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual SeatType SeatType { get; set; }
    }
}
