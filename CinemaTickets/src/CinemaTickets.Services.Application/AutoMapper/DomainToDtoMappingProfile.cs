using System.Linq;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Cinema;
using CinemaTickets.Domain.Dtos.City;
using CinemaTickets.Domain.Dtos.Comment;
using CinemaTickets.Domain.Dtos.Customer;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Dtos.Movie;
using CinemaTickets.Domain.Dtos.MovieSession;
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

            CreateMap<Genre, GenreSampleInfoDto>();

            CreateMap<Movie, MovieInGenreDto>()
                .ForMember(dest => dest.Poster, opt => opt.MapFrom(src => src.Entity.Pictures.FirstOrDefault()))
                .ForMember(dest => dest.HasSessions, opt => opt.MapFrom(src => src.MovieSessions.Any()));

            CreateMap<Customer, CustomerInfoForCommentDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

            CreateMap<Comment, CommentInforForMovieDto>()
                .ForMember(dest => dest.CommentType, opt => opt.MapFrom(src => src.CommentType.Name));

            CreateMap<MovieGenre, GenreSampleInfoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.GenreId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Genre.Name));

            CreateMap<Movie, MovieFullInfoDto>()
                .ForMember(
                    dest => dest.Poster,
                    opt => opt.MapFrom(src => src.Entity.Pictures.FirstOrDefault()))
                .ForMember(
                    dest => dest.Actors,
                    opt => opt.MapFrom(
                        src => src.MovieActors.Select(ma => $"{ma.Actor.FirstName} {ma.Actor.LastName}")))
                .ForMember(
                    dest => dest.Countries,
                    opt => opt.MapFrom(src => src.MovieCountries.Select(mc => mc.Country.Name)))
                .ForMember(
                    dest => dest.Directors,
                    opt => opt.MapFrom(
                        src => src.MovieDirectors.Select(md => $"{md.Director.FirstName} {md.Director.LastName}")))
                .ForMember(
                    dest => dest.Languages,
                    opt => opt.MapFrom(src => src.MovieLanguages.Select(ml => ml.Language.Name)))
                .ForMember(
                    dest => dest.Writers,
                    opt => opt.MapFrom(
                        src => src.MovieWriters.Select(mw => $"{mw.Writer.FirstName} {mw.Writer.LastName}")))
                .ForMember(
                    dest => dest.Comments,
                    opt => opt.MapFrom(src => src.Entity.Comments))
                .ForMember(
                    dest => dest.Genres,
                    opt => opt.MapFrom(src => src.MovieGenres));

            CreateMap<Cinema, CinemaSampleDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ShortName));

            CreateMap<MovieSession, MovieSessionForMovieDto>()
                .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Hall.Format))
                .ForMember(dest => dest.MinPrice, opt => opt.MapFrom(src => src.SessionPrices.Min(sp => sp.Price)))
                .ForMember(dest => dest.Cinema, opt => opt.MapFrom(src => src.Hall.Cinema));

            CreateMap<City, CityWithCinemasDto>();

            CreateMap<Cinema, CinemaNameAndAddressDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Street));
        }
    }
}