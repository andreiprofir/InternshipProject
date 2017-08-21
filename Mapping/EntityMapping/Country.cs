using System.Collections.Generic;

namespace EntityMapping
{
    public partial class Country
    {
        public Country()
        {
            Movies = new HashSet<Movie>();
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
