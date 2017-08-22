using System;
using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Promotion : BaseEntity
    {
        public Promotion()
        {
            Cinemas = new HashSet<Cinema>();
            Movies = new HashSet<Movie>();
        }
        
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
