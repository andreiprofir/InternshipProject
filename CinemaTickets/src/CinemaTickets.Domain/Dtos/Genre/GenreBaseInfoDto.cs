using CinemaTickets.Domain.Dtos.Picture;

namespace CinemaTickets.Domain.Dtos.Genre
{
    public class GenreBaseInfoDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public PictureSampleDto Poster { get; set; }
    }
}