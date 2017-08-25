namespace CinemaTickets.Domain.Core.Models
{
    public partial class MovieCountry
    {
        public long CountryId { get; set; }
        public long MovieId { get; set; }

        public Country Country { get; set; }
        public Movie Movie { get; set; }
    }
}
