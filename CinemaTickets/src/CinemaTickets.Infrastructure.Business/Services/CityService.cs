using System.Collections.Generic;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.City;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class CityService : ICityService
    {
        private ICityRepository _cityRepository;
        private IMapper _mapper;

        public CityService(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        public List<CityWithCinemasDto> GetAllCitiesWithCinemas()
        {
            List<City> source = _cityRepository.GetAllCitiesAndIncludeCinamas(
                Specification.Where<City>(c => c.Cinemas.Count > 0));

            List<CityWithCinemasDto> result = _mapper.Map<List<CityWithCinemasDto>>(source);

            return result;
        }
    }
}