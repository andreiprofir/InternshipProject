using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Actor
    {
        public Actor()
        {
            MovieActors = new HashSet<MovieActor>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
