using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.MovieSession;
using CinemaTickets.Domain.Dtos.Picture;

namespace CinemaTickets.Domain.Dtos.Movie
{
    public class MovieInfoForCinemaSessionsDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public PictureSampleDto Poster { get; set; }

        public List<MovieSessionForCinemaDto> MovieSessions { get; set; }
    }
}