using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Classes
{
    public partial class Writer : BaseEntity
    {
        public Writer()
        {
            Movies = new HashSet<Movie>();
        }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
