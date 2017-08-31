using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public List<MovieInGenreDto> GetMoviesByGenre(long genreId)
        {
            List<Movie> source = _movieRepository.GetMoviesWithIncludePicturesAndSessions(
                Specification.Where<Movie>(m => m.MovieGenres.Any(g => g.GenreId == genreId)));

            List<MovieInGenreDto> result = _mapper.Map<List<MovieInGenreDto>>(source);

            return result;
        }
    }
}