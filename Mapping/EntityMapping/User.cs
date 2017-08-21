using System.Collections.Generic;

namespace EntityMapping
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            Orders = new HashSet<Order>();
            Roles = new HashSet<Role>();
        }

        public long Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Email { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public string PhoneNumber { get; set; }

        public long? AvatarId { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual Picture Picture { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
