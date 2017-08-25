namespace CinemaTickets.Domain.Core.Models
{
    public partial class MovieLanguage
    {
        public long LanguageId { get; set; }
        public long MovieId { get; set; }

        public Language Language { get; set; }
        public Movie Movie { get; set; }
    }
}
