namespace CinemaTickets.Domain.Core.Models
{
    public partial class CinemaPromotion
    {
        public long CinemaId { get; set; }
        public long PromotionId { get; set; }

        public Cinema Cinema { get; set; }
        public Promotion Promotion { get; set; }
    }
}
