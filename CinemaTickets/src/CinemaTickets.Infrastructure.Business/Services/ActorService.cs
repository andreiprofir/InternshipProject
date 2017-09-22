using System.Collections.Generic;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Actor;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class ActorService : IActorService
    {
        private IMapper _mapper;
        private IRepository<Actor> _repository;

        public ActorService(IMapper mapper, IRepository<Actor> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<ActorDto> GetAll()
        {
            List<Actor> source = _repository.GetAll();

            List<ActorDto> result = _mapper.Map<List<ActorDto>>(source);

            return result;
        }
    }
}