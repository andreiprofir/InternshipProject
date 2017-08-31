using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Comments = new HashSet<Comment>();
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AvatarUri { get; set; }
        
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
