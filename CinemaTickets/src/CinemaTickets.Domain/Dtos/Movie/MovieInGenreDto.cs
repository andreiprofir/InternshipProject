using System;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.Picture;

namespace CinemaTickets.Domain.Dtos.Movie
{
    public class MovieInGenreDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public PictureSampleDto Poster { get; set; }

        public DateTimeOffset ReleaseDate { get; set; }

        public bool HasSessions { get; set; }
    }
}