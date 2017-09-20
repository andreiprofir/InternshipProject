using CinemaTickets.Services.Application.ViewModels.Picture;

namespace CinemaTickets.Services.Application.ViewModels.Genre
{
    public class GenreForListOfGenresViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public PictureSampleViewModel Poster { get; set; }
    }
}