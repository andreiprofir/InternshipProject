using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Genre : BaseEntity
    {
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }
        
        public string Name { get; set; }

        public virtual Entity Entity { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
