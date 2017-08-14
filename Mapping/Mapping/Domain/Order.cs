namespace ConsoleApp1.Domain
{
    public class Order : BaseEntity
    {
        public virtual MovieSession MovieSession { get; set; }

        public virtual Seat Seat { get; set; }

        public virtual User User { get; set; }
    }
}
