using System.Collections.Generic;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Actor;
using CinemaTickets.Domain.Dtos.Writer;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class WriterService : IWriterService
    {
        private IMapper _mapper;
        private IRepository<Writer> _repository;

        public WriterService(IMapper mapper, IRepository<Writer> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<WriterDto> GetAll()
        {
            List<Writer> source = _repository.GetAll();

            List<WriterDto> result = _mapper.Map<List<WriterDto>>(source);

            return result;
        }
    }
}