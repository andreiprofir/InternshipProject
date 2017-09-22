using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications.Generics;
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

        public List<MovieInGenreDto> GetMoviesByGenre(long? genreId)
        {
            CriteriaSpecification<Movie> specification = null;

            if (genreId != null)
            {
                specification = Specification.Where<Movie>(m => m.MovieGenres.Any(g => g.GenreId == genreId));
            }

            List<Movie> source = _movieRepository.GetAllAndIncludePicturesAndSessions(specification);

            List<MovieInGenreDto> result = _mapper.Map<List<MovieInGenreDto>>(source);

            return result;
        }

        public MovieFullInfoDto GetFullInfoOfMovieById(long movieId)
        {
            Movie source = _movieRepository.GetByIdAndIncludeAllInfo(movieId);

            MovieFullInfoDto result = _mapper.Map<MovieFullInfoDto>(source);

            return result;
        }

        public List<MovieInfoForListOfPostersDto> GetAllMoviesForPoster(long cinemaId)
        {
            List<Movie> source = _movieRepository.GetAllIncludePicturesAndCinema(
                Specification.Where<Movie>(m => m.MovieSessions.Count(ms => ms.Hall.CinemaId == cinemaId) > 0));

            foreach (Movie movie in source)
            {
                movie.MovieSessions = movie.MovieSessions
                    .Where(ms => ms.Hall.CinemaId == cinemaId)
                    .Where(ms => ms.Time > DateTimeOffset.Now)
                    .ToList();
            }

            List<MovieInfoForListOfPostersDto> result = _mapper.Map<List<MovieInfoForListOfPostersDto>>(source);

            return result;
        }

        public void Delete(long id)
        {
            _movieRepository.Delete(id);

            _movieRepository.SaveChanges();
        }

        public MovieDto Get(long id)
        {
            Movie source = _movieRepository.GetByIdWithIncludeDependences(id);

            MovieDto result = _mapper.Map<MovieDto>(source);

            return result;
        }
    }
}