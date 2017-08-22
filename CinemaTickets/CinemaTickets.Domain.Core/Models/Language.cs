using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Language : BaseEntity
    {
        public Language()
        {
            Movies = new HashSet<Movie>();
        }
        
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
