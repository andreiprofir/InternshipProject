using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Director
    {
        public Director()
        {
            MovieDirectors = new HashSet<MovieDirector>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<MovieDirector> MovieDirectors { get; set; }
    }
}
