using System.Linq;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Movie;

namespace CinemaTickets.Services.Application.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<MovieDto, Movie>()
                .ForMember(dest => dest.MovieActors,
                    opt => opt.MapFrom(src =>
                        src.MovieActors.Select(id => new MovieActor {MovieId = src.Id, ActorId = id })))
                
                .ForMember(dest => dest.MovieCountries,
                    opt => opt.MapFrom(src =>
                        src.MovieCountries.Select(id => new MovieCountry { MovieId = src.Id, CountryId = id })))

                .ForMember(dest => dest.MovieDirectors,
                    opt => opt.MapFrom(src =>
                        src.MovieDirectors.Select(id => new MovieDirector { MovieId = src.Id, DirectorId = id })))

                .ForMember(dest => dest.MovieGenres,
                    opt => opt.MapFrom(src =>
                        src.MovieGenres.Select(id => new MovieGenre { MovieId = src.Id, GenreId = id })))

                .ForMember(dest => dest.MovieLanguages,
                    opt => opt.MapFrom(src =>
                        src.MovieLanguages.Select(id => new MovieLanguage { MovieId = src.Id, LanguageId = id })))

                .ForMember(dest => dest.MovieWriters,
                    opt => opt.MapFrom(src =>
                        src.MovieWriters.Select(id => new MovieWriter { MovieId = src.Id, WriterId = id })));
        }
    }
}