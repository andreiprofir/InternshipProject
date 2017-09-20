using System.Collections.Generic;
using CinemaTickets.Services.Application.ViewModels.Movie;
using CinemaTickets.Services.Application.ViewModels.Picture;

namespace CinemaTickets.Services.Application.ViewModels.Genre
{
    public class GenreViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public PictureSampleViewModel Poster { get; set; }

        public List<MovieInGenreViewModel> Movies { get; set; }
    }
}