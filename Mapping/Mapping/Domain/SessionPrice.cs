
namespace ConsoleApp1.Domain
{
    public class SessionPrice : BaseEntity
    {
        public virtual MovieSession MovieSession { get; set; }

        public virtual SeatType SeatType { get; set; }

        public virtual decimal Price { get; set; }
    }
}
