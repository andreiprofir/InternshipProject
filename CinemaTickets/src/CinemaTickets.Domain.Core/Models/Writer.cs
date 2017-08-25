using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Writer
    {
        public Writer()
        {
            MovieWriters = new HashSet<MovieWriter>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<MovieWriter> MovieWriters { get; set; }
    }
}
