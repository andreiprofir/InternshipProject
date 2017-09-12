using System;
using CinemaTickets.Services.Application.ViewModels.Cinema;

namespace CinemaTickets.Services.Application.ViewModels.MovieSession
{
    public class MovieSessionForMovieViewModel
    {
        public long Id { get; set; }

        public DateTimeOffset Time { get; set; }

        public string Format { get; set; }

        public decimal MinPrice { get; set; }

        public CinemaSampleViewModel Cinema { get; set; }
    }
}