using System;

namespace CinemaTickets.Domain.Dtos.MovieSession
{
    public class MovieSessionForCinemaDto
    {
        public long Id { get; set; }

        public DateTimeOffset Time { get; set; }

        public string Format { get; set; }

        public decimal MinPrice { get; set; }
    }
}