using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            Orders = new HashSet<Order>();
            UserRoles = new HashSet<UserRole>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string PhoneNumber { get; set; }
        public long? AvatarId { get; set; }

        public Picture Avatar { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
