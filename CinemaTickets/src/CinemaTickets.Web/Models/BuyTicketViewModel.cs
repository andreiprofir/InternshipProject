using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CinemaTickets.Web.Models
{
    public class BuyTicketViewModel
    {
        [Required]
        public long MovieSessionId { get; set; }

        [DisplayName("Please, select seat for Buy")]
        [Required]
        public long SeatId { get; set; }
    }
}