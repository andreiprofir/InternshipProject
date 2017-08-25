namespace CinemaTickets.Domain.Core.Models
{
    public partial class Order
    {
        public long Id { get; set; }
        public long MovieSessionId { get; set; }
        public long SeatId { get; set; }
        public long UserId { get; set; }

        public MovieSession MovieSession { get; set; }
        public Seat Seat { get; set; }
        public User User { get; set; }
    }
}
