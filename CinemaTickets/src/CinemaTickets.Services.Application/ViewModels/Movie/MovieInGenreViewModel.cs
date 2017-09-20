using System;
using CinemaTickets.Services.Application.ViewModels.Picture;

namespace CinemaTickets.Services.Application.ViewModels.Movie
{
    public class MovieInGenreViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public PictureSampleViewModel Poster { get; set; }

        public DateTimeOffset ReleaseDate { get; set; }

        public bool HasSessions { get; set; }
    }
}