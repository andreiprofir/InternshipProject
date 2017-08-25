namespace CinemaTickets.Domain.Core.Models
{
    public partial class MovieWriter
    {
        public long MovieId { get; set; }
        public long WriterId { get; set; }

        public Movie Movie { get; set; }
        public Writer Writer { get; set; }
    }
}
