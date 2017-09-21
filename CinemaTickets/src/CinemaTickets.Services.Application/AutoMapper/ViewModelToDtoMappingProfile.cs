using AutoMapper;
using CinemaTickets.Domain.Dtos.Actor;
using CinemaTickets.Domain.Dtos.Country;
using CinemaTickets.Domain.Dtos.Director;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.Language;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Domain.Dtos.User;
using CinemaTickets.Domain.Dtos.Writer;
using CinemaTickets.Services.Application.ViewModels;
using CinemaTickets.Services.Application.ViewModels.Actor;
using CinemaTickets.Services.Application.ViewModels.Country;
using CinemaTickets.Services.Application.ViewModels.Director;
using CinemaTickets.Services.Application.ViewModels.Genre;
using CinemaTickets.Services.Application.ViewModels.Language;
using CinemaTickets.Services.Application.ViewModels.Movie;
using CinemaTickets.Services.Application.ViewModels.User;

namespace CinemaTickets.Services.Application.AutoMapper
{
    public class ViewModelToDtoMappingProfile : Profile
    {
        public ViewModelToDtoMappingProfile()
        {
            CreateMap<UserForListViewModels, UserWithRolesDto>();

            CreateMap<ActorViewModel, ActorDto>();
            CreateMap<CountryViewModel, CountryDto>();
            CreateMap<DirectorViewModel, DirectorDto>();
            CreateMap<LanguageViewModel, LanguageDto>();
            CreateMap<WriterViewModel, WriterDto>();
            CreateMap<GenreSampleViewModel, GenreSampleInfoDto>();
            CreateMap<MovieViewModel, MovieDto>();
        }
    }
}