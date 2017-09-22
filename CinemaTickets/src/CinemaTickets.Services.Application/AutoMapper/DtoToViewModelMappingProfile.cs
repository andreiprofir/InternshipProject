using System.Linq;
using AutoMapper;
using CinemaTickets.Domain.Dtos.Actor;
using CinemaTickets.Domain.Dtos.Cinema;
using CinemaTickets.Domain.Dtos.City;
using CinemaTickets.Domain.Dtos.Comment;
using CinemaTickets.Domain.Dtos.Country;
using CinemaTickets.Domain.Dtos.Customer;
using CinemaTickets.Domain.Dtos.Director;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.Language;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Domain.Dtos.MovieSession;
using CinemaTickets.Domain.Dtos.Picture;
using CinemaTickets.Domain.Dtos.User;
using CinemaTickets.Domain.Dtos.Writer;
using CinemaTickets.Services.Application.ViewModels;
using CinemaTickets.Services.Application.ViewModels.Actor;
using CinemaTickets.Services.Application.ViewModels.Cinema;
using CinemaTickets.Services.Application.ViewModels.City;
using CinemaTickets.Services.Application.ViewModels.Comment;
using CinemaTickets.Services.Application.ViewModels.Country;
using CinemaTickets.Services.Application.ViewModels.Customer;
using CinemaTickets.Services.Application.ViewModels.Director;
using CinemaTickets.Services.Application.ViewModels.Genre;
using CinemaTickets.Services.Application.ViewModels.Language;
using CinemaTickets.Services.Application.ViewModels.Movie;
using CinemaTickets.Services.Application.ViewModels.MovieSession;
using CinemaTickets.Services.Application.ViewModels.Picture;
using CinemaTickets.Services.Application.ViewModels.User;

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

            CreateMap<CustomerInfoForCommentDto, CustomerInfoForCommentViewModel>();

            CreateMap<CommentInfoDto, CommentInfoViewModel>();

            CreateMap<GenreSampleInfoDto, GenreSampleViewModel>();

            CreateMap<MovieFullInfoDto, MovieInfoViewModel>();

            CreateMap<GenreBaseInfoDto, GenreForListOfGenresViewModel>();

            CreateMap<MovieInGenreDto, MovieInGenreViewModel>();

            CreateMap<GenreBaseInfoDto, GenreViewModel>()
                .ForMember(dest => dest.Movies, opt => opt.Ignore());

            CreateMap<CitySampleDto, CitySampleViewModel>();

            CreateMap<CinemaForListDto, CinemaForListViewModel>();

            CreateMap<UserWithRolesDto, UserForListViewModels>();

            CreateMap<ActorDto, ActorViewModel>();
            CreateMap<CountryDto, CountryViewModel>();
            CreateMap<DirectorDto, DirectorViewModel>();
            CreateMap<LanguageDto, LanguageViewModel>();
            CreateMap<WriterDto, WriterViewModel>();
            CreateMap<MovieDto, MovieViewModel>();
        }
    }
}