using System.Collections.Generic;

namespace EntityMapping
{
    public partial class Director
    {
        public Director()
        {
            Movies = new HashSet<Movie>();
        }

        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
