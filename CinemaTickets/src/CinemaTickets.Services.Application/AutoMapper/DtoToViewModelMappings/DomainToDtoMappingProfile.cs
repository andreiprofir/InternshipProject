using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Genre;

namespace CinemaTickets.Services.Application.AutoMapper.DtoToViewModelMappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Genre, GenreDto>();
        }
    }
}