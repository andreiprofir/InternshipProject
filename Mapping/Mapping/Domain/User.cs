using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class User : BaseEntity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }

        public virtual string Password { get; set; }

        public virtual string Salt { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual Picture Avatar { get; set; }

        public virtual IList<Role> Roles { get; set; }

        public virtual IList<Order> Orders { get; set; }
    }
}
