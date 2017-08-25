namespace CinemaTickets.Domain.Core.Models
{
    public partial class SessionPrice
    {
        public long Id { get; set; }
        public decimal Price { get; set; }
        public long MovieSessionId { get; set; }
        public long SeatTypeId { get; set; }

        public MovieSession MovieSession { get; set; }
        public SeatType SeatType { get; set; }
    }
}
