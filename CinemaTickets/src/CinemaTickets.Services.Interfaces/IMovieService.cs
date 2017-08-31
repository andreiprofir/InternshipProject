using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Movie;

namespace CinemaTickets.Services.Interfaces
{
    public interface IMovieService
    {
        List<MovieInGenreDto> GetMoviesByGenre(long genreId);

        MovieFullInfoDto GetFullInfoOfMovieById(long movieId);
    }
}