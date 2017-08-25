namespace CinemaTickets.Domain.Core.Models
{
    public partial class MovieGenre
    {
        public long GenreId { get; set; }
        public long MovieId { get; set; }

        public Genre Genre { get; set; }
        public Movie Movie { get; set; }
    }
}
