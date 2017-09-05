using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Cinema;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications.Generics;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class CinemaService : ICinemaService
    {
        private readonly ICinemaRepository _cinemaRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public CinemaService(ICinemaRepository cinemaRepository, IMovieRepository movieRepository, IMapper mapper)
        {
            _cinemaRepository = cinemaRepository;
            _movieRepository = movieRepository;
            _mapper = mapper;
        }


        public List<CinemaForListDto> GetAllByCityId(long? cityId = null)
        {
            CriteriaSpecification<Cinema> specification = null;

            if (cityId != null)
                specification = Specification.Where<Cinema>(c => c.CityId == cityId);

            List<Cinema> source = _cinemaRepository.GetAllIncludeCityAndHallsAndPictures(specification);

            List<CinemaForListDto> result = _mapper.Map<List<CinemaForListDto>>(source);

            return result;
        }

        public CinemaFullInfoDto GetById(long cinemaId)
        {
            Cinema source = _cinemaRepository.GetByIdWithFullInfo(
                Specification.Where<Cinema>(c => c.Id == cinemaId));

            List<Movie> movies = _movieRepository.GetAllIncludePictures(
                Specification.Where<Movie>(m => m.MovieSessions.Any(ms => ms.Hall.CinemaId == cinemaId)));

            CinemaFullInfoDto result = _mapper.Map<CinemaFullInfoDto>(source);

            result.MovieSessions = _mapper.Map<List<MovieInfoForCinemaSessionsDto>>(movies);

            return result;
            //-si aici trebuie sa ma duc in Movie si sa incarc in lista din source toate MovieSession
            //deja o sa folosesc repositoriul IMovieRepository in care trebuie sa mai creez o metoda
            //care va incarca toate datele de care am nevoie
        }
    }
}