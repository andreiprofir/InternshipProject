using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Infrastructure.Data.Models.Identity;

namespace CinemaTickets.Infrastructure.Data.Models
{
    public class UserCustomer : Customer
    {
        public User User { get; set; }
    }
}