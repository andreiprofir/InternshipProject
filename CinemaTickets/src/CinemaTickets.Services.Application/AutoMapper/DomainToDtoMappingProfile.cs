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
using CinemaTickets.Domain.Dtos.Promotion;

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

            CreateMap<Comment, CommentInfoDto>()
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
                .ForMember(dest => dest.MinPrice, 
                    opt => opt.MapFrom(src => src.SessionPrices.DefaultIfEmpty().Min(sp => sp.Price)))
                .ForMember(dest => dest.Cinema, opt => opt.MapFrom(src => src.Hall.Cinema));

            CreateMap<City, CityWithCinemasDto>();

            CreateMap<Cinema, CinemaNameAndAddressDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Street));

            CreateMap<Promotion, PromotionFullInfoDto>()
                .ForMember(
                    dest => dest.Poster, 
                    opt => opt.MapFrom(src => src.Entity.Pictures.LastOrDefault()))
                .ForMember(
                    dest => dest.MoviePromotions,
                    opt => opt.MapFrom(src => src.MoviePromotions.Select(mp => mp.Movie)))
                .ForMember(
                    dest => dest.CinemaPromotions,
                    opt => opt.MapFrom(src => src.CinemaPromotions.Select(cp => cp.Cinema)));

            CreateMap<Movie, MovieBaseInfoDto>()
                .ForMember(dest => dest.Poster, opt => opt.MapFrom(src => src.Entity.Pictures.FirstOrDefault()));

            CreateMap<Cinema, CinemaForPromotionDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name));

            CreateMap<Promotion, PromotionForListDto>()
                .ForMember(dest => dest.Poster, opt => opt.MapFrom(src => src.Entity.Pictures.FirstOrDefault()))
                .ForMember(
                    dest => dest.Cinemas,
                    opt => opt.MapFrom(src => src.CinemaPromotions.Select(cp => cp.Cinema)));

            CreateMap<Movie, MovieInfoForListOfPostersDto>()
                .ForMember(dest => dest.Poster, opt => opt.MapFrom(src => src.Entity.Pictures.FirstOrDefault()))
                .ForMember(dest => dest.MovieSessions, opt => opt.MapFrom(src => src.MovieSessions));

            CreateMap<City, CitySampleDto>();

            CreateMap<Cinema, CinemaForListDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Street))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.ContactPhone))
                .ForMember(dest => dest.Formats, opt => opt.MapFrom(src => src.Halls.Select(h => h.Format).Distinct()))
                .ForMember(dest => dest.Poster, opt => opt.MapFrom(src => src.Entity.Pictures.FirstOrDefault()));



            CreateMap<MovieSession, MovieSessionForCinemaDto>()
                .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Hall.Format))
                .ForMember(dest => dest.MinPrice,
                    opt => opt.MapFrom(src => src.SessionPrices.DefaultIfEmpty().Min(sp => sp.Price)));

            CreateMap<Movie, MovieInfoForCinemaSessionsDto>()
                .ForMember(dest => dest.Poster, opt => opt.MapFrom(src => src.Entity.Pictures.FirstOrDefault()));

            CreateMap<Cinema, CinemaFullInfoDto>()
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name))
                .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Entity.Comments))
                .ForMember(dest => dest.Pictures, opt => opt.MapFrom(src => src.Entity.Pictures))
                .ForMember(dest => dest.MovieSessions, opt => opt.Ignore());
        }
    }
}