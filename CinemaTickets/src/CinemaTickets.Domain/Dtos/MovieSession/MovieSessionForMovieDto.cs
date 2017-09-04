using System;
using CinemaTickets.Domain.Dtos.Cinema;

namespace CinemaTickets.Domain.Dtos.MovieSession
{
    public class MovieSessionForMovieDto
    {
        public long Id { get; set; }

        public DateTimeOffset Time { get; set; }

        public string Format { get; set; }

        public decimal MinPrice { get; set; }

        public CinemaSampleDto Cinema { get; set; }
    }
}