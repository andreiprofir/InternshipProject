using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.Picture;

namespace CinemaTickets.Services.Application.AutoMapper.DtoToViewModelMappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Genre, GenreDto>();

            CreateMap<Genre, GenreFullInfoDto>()
                .ForMember(x => x.Pictures, y => y.MapFrom(z => z.IdNavigation.Pictures));

            CreateMap<Picture, PictureDto>();
        }
    }
}