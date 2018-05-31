using System.Linq;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos;
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
using CinemaTickets.Domain.Dtos.Promotion;
using CinemaTickets.Domain.Dtos.User;
using CinemaTickets.Domain.Dtos.Writer;
using CinemaTickets.Infrastructure.Data.Mappings;
using CinemaTickets.Infrastructure.Data.Models.Identity;

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

            CreateMap<User, UserWithRolesDto>()
                .ForMember(dest => dest.Roles, opt => opt.Ignore());

            CreateMap<MovieActor, ActorDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ActorId))
                .ForMember(dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.Actor.FirstName} {src.Actor.LastName}"));

            CreateMap<MovieCountry, CountryDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CountryId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Country.Name));

            CreateMap<MovieDirector, DirectorDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DirectorId))
                .ForMember(dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.Director.FirstName} {src.Director.LastName}")); 

            CreateMap<MovieLanguage, LanguageDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.LanguageId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Language.Name));

            CreateMap<MovieWriter, WriterDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.WriterId))
                .ForMember(dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.Writer.FirstName} {src.Writer.LastName}"));

            CreateMap<Movie, MovieDto>()
                .ForMember(dest => dest.MovieActors, 
                    opt => opt.MapFrom(src => src.MovieActors.Select(ma => ma.ActorId)))
                .ForMember(dest => dest.MovieGenres,
                    opt => opt.MapFrom(src => src.MovieGenres.Select(ma => ma.GenreId)))
                .ForMember(dest => dest.MovieCountries,
                    opt => opt.MapFrom(src => src.MovieCountries.Select(ma => ma.CountryId)))
                .ForMember(dest => dest.MovieDirectors,
                    opt => opt.MapFrom(src => src.MovieDirectors.Select(ma => ma.DirectorId)))
                .ForMember(dest => dest.MovieLanguages,
                    opt => opt.MapFrom(src => src.MovieLanguages.Select(ma => ma.LanguageId)))
                .ForMember(dest => dest.MovieWriters,
                    opt => opt.MapFrom(src => src.MovieWriters.Select(ma => ma.WriterId)));

            CreateMap<Actor, ActorDto>()
                .ForMember(dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

            CreateMap<Country, CountryDto>();

            CreateMap<Director, DirectorDto>()
                .ForMember(dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

            CreateMap<Language, LanguageDto>();

            CreateMap<Writer, WriterDto>()
                .ForMember(dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

            CreateMap<Order, OrderDto>()
                .ForMember(dest => dest.MovieId, opt => opt.MapFrom(src => src.MovieSession.MovieId))
                .ForMember(dest => dest.MovieTitle, opt => opt.MapFrom(src => src.MovieSession.Movie.OriginalName))
                .ForMember(dest => dest.SeatType, opt => opt.MapFrom(src => src.Seat.SeatType.Name))
                .ForMember(dest => dest.RowNumber, opt => opt.MapFrom(src => src.Seat.RowNumber))
                .ForMember(dest => dest.ColumnNumber, opt => opt.MapFrom(src => src.Seat.ColumnNumber));
        }
    }
}