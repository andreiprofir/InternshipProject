using System.Linq;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.Picture;

namespace CinemaTickets.Services.Application.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Genre, GenreBaseInfoDto>()
                .ForMember(dest => dest.Poster, opt => opt.MapFrom(src => src.Entity.Pictures.FirstOrDefault()));

            CreateMap<Picture, PictureSampleDto>();
        }
    }
}