using System.Collections.Generic;
using AutoMapper;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using CinemaTickets.Services.Interfaces;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public GenreService(IGenreRepository genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public List<GenreBaseInfoDto> GetAll()
        {
            List<Genre> source = _genreRepository.GetListOfGenresWithIncludePictures(
                Specification.OrderBy<Genre>(g => g.Name));

            List<GenreBaseInfoDto> result = _mapper.Map<List<GenreBaseInfoDto>>(source);

            return result;
        }

        public GenreSampleInfoDto GetById(long genreId)
        {
            Genre source = _genreRepository.Get(genreId);

            GenreSampleInfoDto result = _mapper.Map<GenreSampleInfoDto>(source);

            return result;
        }
    }
}