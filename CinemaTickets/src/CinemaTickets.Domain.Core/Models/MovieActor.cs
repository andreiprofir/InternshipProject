namespace CinemaTickets.Domain.Core.Models
{
    public partial class MovieActor
    {
        public long ActorId { get; set; }
        public long MovieId { get; set; }

        public Actor Actor { get; set; }
        public Movie Movie { get; set; }
    }
}
