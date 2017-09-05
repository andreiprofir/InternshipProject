using System.Collections.Generic;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Cinema;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications.Generics;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class CinemaService : ICinemaService
    {
        private readonly ICinemaRepository _cinemaRepository;
        private readonly IMapper _mapper;

        public CinemaService(ICinemaRepository cinemaRepository, IMapper mapper)
        {
            _cinemaRepository = cinemaRepository;
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
    }
}