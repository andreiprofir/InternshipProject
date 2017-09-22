using System.Collections.Generic;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Actor;
using CinemaTickets.Domain.Dtos.Language;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class LanguageService : ILanguageService
    {
        private IMapper _mapper;
        private IRepository<Language> _repository;

        public LanguageService(IMapper mapper, IRepository<Language> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<LanguageDto> GetAll()
        {
            List<Language> source = _repository.GetAll();

            List<LanguageDto> result = _mapper.Map<List<LanguageDto>>(source);

            return result;
        }
    }
}