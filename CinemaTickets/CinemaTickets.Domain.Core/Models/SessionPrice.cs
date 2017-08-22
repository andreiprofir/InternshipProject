namespace CinemaTickets.Domain.Core.Models
{
    public partial class SessionPrice : BaseEntity
    {   
        public decimal Price { get; set; }

        public long MovieSessionId { get; set; }

        public long SeatTypeId { get; set; }

        public virtual MovieSession MovieSession { get; set; }

        public virtual SeatType SeatType { get; set; }
    }
}
