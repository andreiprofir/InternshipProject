using System.Collections.Generic;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Actor;
using CinemaTickets.Domain.Dtos.Country;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class CountryService : ICountryService
    {
        private IMapper _mapper;
        private IRepository<Country> _repository;

        public CountryService(IMapper mapper, IRepository<Country> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<CountryDto> GetAll()
        {
            List<Country> source = _repository.GetAll();

            List<CountryDto> result = _mapper.Map<List<CountryDto>>(source);

            return result;
        }
    }
}