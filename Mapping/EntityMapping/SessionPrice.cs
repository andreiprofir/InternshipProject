using System.ComponentModel.DataAnnotations.Schema;

namespace EntityMapping
{
    public partial class SessionPrice
    {
        public long Id { get; set; }
        
        public decimal Price { get; set; }

        public long MovieSessionId { get; set; }

        public long SeatTypeId { get; set; }

        public virtual MovieSession MovieSession { get; set; }

        public virtual SeatType SeatType { get; set; }
    }
}
