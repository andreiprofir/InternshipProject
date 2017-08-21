namespace EntityMapping
{
    public partial class Order
    {
        public long Id { get; set; }

        public long MovieSessionId { get; set; }

        public long SeatId { get; set; }

        public long UserId { get; set; }

        public virtual MovieSession MovieSession { get; set; }

        public virtual Seat Seat { get; set; }

        public virtual User User { get; set; }
    }
}
