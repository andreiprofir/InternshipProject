using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Movie;

namespace CinemaTickets.Services.Interfaces
{
    public interface IMovieService
    {
        List<MovieInGenreDto> GetMoviesByGenre(long? genreId = null);

        MovieFullInfoDto GetFullInfoOfMovieById(long movieId);

        List<MovieInfoForListOfPostersDto> GetAllMoviesForPoster(long cinemaId);

        void Delete(long id);

        MovieDto Get(long id);
        void Update(MovieDto movie);
    }
}