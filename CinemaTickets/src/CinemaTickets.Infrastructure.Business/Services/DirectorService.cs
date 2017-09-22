using System.Collections.Generic;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Country;
using CinemaTickets.Domain.Dtos.Director;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class DirectorService : IDirectorService
    {
        private IMapper _mapper;
        private IRepository<Director> _repository;

        public DirectorService(IMapper mapper, IRepository<Director> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<DirectorDto> GetAll()
        {
            List<Director> source = _repository.GetAll();

            List<DirectorDto> result = _mapper.Map<List<DirectorDto>>(source);

            return result;
        }
    }
}