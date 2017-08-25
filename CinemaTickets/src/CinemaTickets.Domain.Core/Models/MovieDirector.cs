namespace CinemaTickets.Domain.Core.Models
{
    public partial class MovieDirector
    {
        public long DirectorId { get; set; }
        public long MovieId { get; set; }

        public Director Director { get; set; }
        public Movie Movie { get; set; }
    }
}
