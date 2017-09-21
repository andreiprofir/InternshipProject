using System.Collections.Generic;

namespace CinemaTickets.Domain.Dtos.User
{
    public class UserWithRolesDto
    {
        public long Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public List<string> Roles { get; set; }
    }
}