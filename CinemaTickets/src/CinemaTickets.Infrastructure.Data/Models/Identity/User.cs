using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace CinemaTickets.Infrastructure.Data.Models.Identity
{
    public class User : IdentityUser<long>
    {
        public UserCustomer Customer { get; set; }

        public decimal Wallet { get; set; }
    }
}