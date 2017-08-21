using System.Collections.Generic;

namespace EntityMapping
{
    public partial class Genre
    {
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }

        public long Id { get; set; }
        
        public string Name { get; set; }

        public virtual Entity Entity { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
