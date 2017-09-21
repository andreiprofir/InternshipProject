using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaTickets.Services.Application.ViewModels.User
{
    public class UserForListViewModels
    {
        public long Id { get; set; }

        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        public List<string> Roles { get; set; }
    }
}