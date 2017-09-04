using CinemaTickets.Domain.Dtos.Picture;

namespace CinemaTickets.Domain.Dtos.Movie
{
    public class MovieBaseInfoDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public PictureSampleDto Poster { get; set; }
    }
}