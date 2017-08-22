using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Director : BaseEntity
    {
        public Director()
        {
            Movies = new HashSet<Movie>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
