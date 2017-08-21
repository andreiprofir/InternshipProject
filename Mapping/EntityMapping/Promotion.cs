using System;
using System.Collections.Generic;

namespace EntityMapping
{
    public partial class Promotion
    {
        public Promotion()
        {
            Cinemas = new HashSet<Cinema>();
            Movies = new HashSet<Movie>();
        }

        public long Id { get; set; }
        
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string DescriptionOfRules { get; set; }

        public DateTimeOffset? ValidFrom { get; set; }

        public DateTimeOffset? ValidTo { get; set; }

        public virtual Entity Entity { get; set; }

        public virtual ICollection<Cinema> Cinemas { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
