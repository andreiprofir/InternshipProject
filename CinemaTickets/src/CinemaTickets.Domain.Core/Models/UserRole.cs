namespace CinemaTickets.Domain.Core.Models
{
    public partial class UserRole
    {
        public long RoleId { get; set; }
        public long UserId { get; set; }

        public Role Role { get; set; }
        public User User { get; set; }
    }
}
