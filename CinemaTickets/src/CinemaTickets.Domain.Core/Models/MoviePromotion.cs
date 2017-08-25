namespace CinemaTickets.Domain.Core.Models
{
    public partial class MoviePromotion
    {
        public long MovieId { get; set; }
        public long PromotionId { get; set; }

        public Movie Movie { get; set; }
        public Promotion Promotion { get; set; }
    }
}
