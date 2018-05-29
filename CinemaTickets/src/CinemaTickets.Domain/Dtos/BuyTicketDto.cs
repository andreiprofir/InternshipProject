namespace CinemaTickets.Domain.Dtos
{
    public class BuyTicketDto
    {
        public long MovieSessionId { get; set; }

        public long SeatId { get; set; }
    }
}