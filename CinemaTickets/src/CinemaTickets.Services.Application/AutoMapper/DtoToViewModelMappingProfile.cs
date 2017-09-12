using AutoMapper;
using CinemaTickets.Domain.Dtos.Cinema;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Domain.Dtos.MovieSession;
using CinemaTickets.Domain.Dtos.Picture;
using CinemaTickets.Services.Application.ViewModels.Cinema;
using CinemaTickets.Services.Application.ViewModels.Movie;
using CinemaTickets.Services.Application.ViewModels.MovieSession;
using CinemaTickets.Services.Application.ViewModels.Picture;

namespace CinemaTickets.Services.Application.AutoMapper
{
    public class DtoToViewModelMappingProfile : Profile
    {
        public DtoToViewModelMappingProfile()
        {
            CreateMap<PictureSampleDto, PictureSampleViewModel>();

            CreateMap<CinemaSampleDto, CinemaSampleViewModel>();

            CreateMap<MovieSessionForMovieDto, MovieSessionForMovieViewModel>();

            CreateMap<MovieInfoForListOfPostersDto, MovieForPosterViewModel>();
        }
    }
}