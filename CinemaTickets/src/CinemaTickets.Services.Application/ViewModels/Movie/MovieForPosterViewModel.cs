using System.Collections.Generic;
using CinemaTickets.Services.Application.ViewModels.MovieSession;
using CinemaTickets.Services.Application.ViewModels.Picture;

namespace CinemaTickets.Services.Application.ViewModels.Movie
{
    public class MovieForPosterViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public PictureSampleViewModel Poster { get; set; }

        public List<MovieSessionForMovieViewModel> MovieSessions { get; set; }
    }
}