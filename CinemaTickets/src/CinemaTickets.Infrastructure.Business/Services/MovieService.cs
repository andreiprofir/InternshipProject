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
        private IMovieRepository _movieRepository;
        private IMapper _mapper;
        private IRepository<MovieActor> _movieActorRepository;
        private IRepository<MovieDirector> _movieDirectorRepository;
        private IRepository<MovieCountry> _movieCountryRepository;
        private IRepository<MovieLanguage> _movieLanguageRepository;
        private IRepository<MovieWriter> _movieWriterRepository;
        private IRepository<MovieGenre> _movieGenreRepository;
        private IRepository<Entity> _entityRepository;

        public MovieService(IMovieRepository movieRepository, 
            IRepository<MovieActor> movieActorRepository, 
            IMapper mapper, 
            IRepository<MovieDirector> movieDirectorRepository, 
            IRepository<MovieCountry> movieCountryRepository, 
            IRepository<MovieLanguage> movieLanguageRepository,
            IRepository<MovieWriter> movieWriterRepository, 
            IRepository<MovieGenre> movieGenreRepository, 
            IRepository<Entity> entityRepository)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
            _movieDirectorRepository = movieDirectorRepository;
            _movieCountryRepository = movieCountryRepository;
            _movieLanguageRepository = movieLanguageRepository;
            _movieWriterRepository = movieWriterRepository;
            _movieGenreRepository = movieGenreRepository;
            _entityRepository = entityRepository;
            _movieActorRepository = movieActorRepository;
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

        public void Update(MovieDto movie)
        {
            Movie domainModel = _mapper.Map<Movie>(movie);

            if (domainModel.Id == 0)
            {
                var entity = _entityRepository.Add(new Entity());
                _entityRepository.SaveChanges();
                domainModel.Entity = entity;
                domainModel.Id = entity.Id;
                domainModel = _movieRepository.Add(domainModel);
                _movieRepository.SaveChanges();
                movie.Id = entity.Id;
            }
            else
            {
                _movieRepository.Update(domainModel);

                domainModel = _movieRepository.GetByIdAndIncludeAllInfo(domainModel.Id);

                DeleteAllMany(domainModel);

                _movieActorRepository.SaveChanges();
                _movieDirectorRepository.SaveChanges();
                _movieCountryRepository.SaveChanges();
                _movieLanguageRepository.SaveChanges();
                _movieWriterRepository.SaveChanges();
                _movieGenreRepository.SaveChanges();
                _movieRepository.SaveChanges();

                AddNewAllManyData(domainModel, movie);

                //_movieRepository.Update(domainModel);

                _movieActorRepository.SaveChanges();
                _movieDirectorRepository.SaveChanges();
                _movieCountryRepository.SaveChanges();
                _movieLanguageRepository.SaveChanges();
                _movieWriterRepository.SaveChanges();
                _movieGenreRepository.SaveChanges();
                _movieRepository.SaveChanges();
            }
        }

        private void AddNewAllManyData(Movie domainModel, MovieDto movieDto)
        {
            foreach (long movieActorId in movieDto.MovieActors)
            {
                _movieActorRepository.Add(new MovieActor {ActorId = movieActorId, MovieId = domainModel.Id});
            }

            foreach (long movieDirectorId in movieDto.MovieDirectors)
            {
                _movieDirectorRepository.Add(new MovieDirector {DirectorId = movieDirectorId, MovieId = domainModel.Id});
            }

            foreach (long movieCountryId in movieDto.MovieCountries)
            {
                _movieCountryRepository.Add(new MovieCountry {CountryId = movieCountryId, MovieId = domainModel.Id});
            }

            foreach (long movieLanguageId in movieDto.MovieLanguages)
            {
                _movieLanguageRepository.Add(new MovieLanguage {LanguageId = movieLanguageId, MovieId = domainModel.Id});
            }

            foreach (long movieWriterId in movieDto.MovieWriters)
            {
                _movieWriterRepository.Add(new MovieWriter {WriterId = movieWriterId, MovieId = domainModel.Id});
            }

            foreach (long movieGenreId in movieDto.MovieGenres)
            {
                _movieGenreRepository.Add(new MovieGenre {GenreId = movieGenreId, MovieId = domainModel.Id});
            }
        }

        private void DeleteAllMany(Movie movie)
        {
            foreach (MovieActor movieActor in movie.MovieActors)
            {
                _movieActorRepository.Delete(movieActor);
            }
            movie.MovieActors.Clear();

            foreach (MovieDirector movieDirector in movie.MovieDirectors)
            {
                _movieDirectorRepository.Delete(movieDirector);
            }
            movie.MovieDirectors.Clear();

            foreach (MovieCountry movieCountry in movie.MovieCountries)
            {
                _movieCountryRepository.Delete(movieCountry);
            }
            movie.MovieCountries.Clear();

            foreach (MovieLanguage movieLanguage in movie.MovieLanguages)
            {
                _movieLanguageRepository.Delete(movieLanguage);
            }
            movie.MovieLanguages.Clear();

            foreach (MovieWriter movieWriter in movie.MovieWriters)
            {
                _movieWriterRepository.Delete(movieWriter);
            }
            movie.MovieWriters.Clear();

            foreach (MovieGenre movieGenre in movie.MovieGenres)
            {
                _movieGenreRepository.Delete(movieGenre);
            }
            movie.MovieGenres.Clear();
        }
    }
}