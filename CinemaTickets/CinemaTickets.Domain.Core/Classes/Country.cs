using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Classes
{
    public partial class Country : BaseEntity
    {
        public Country()
        {
            Movies = new HashSet<Movie>();
        }

        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
