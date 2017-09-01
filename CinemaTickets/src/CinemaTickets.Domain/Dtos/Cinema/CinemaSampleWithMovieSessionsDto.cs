using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.MovieSession;

namespace CinemaTickets.Domain.Dtos.Cinema
{
    public class CinemaSampleWithMovieSessionsDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public List<MovieSessionForMovieDto> MovieSessions { get; set; }
    }
}