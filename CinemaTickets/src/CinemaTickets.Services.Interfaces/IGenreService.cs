using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Genre;

namespace CinemaTickets.Services.Interfaces
{
    public interface IGenreService
    {
        List<GenreBaseInfoDto> GetAll();

        GenreSampleInfoDto GetById(long genreId);

        GenreBaseInfoDto GetBaseInfoById(long genreId);

        List<GenreSampleInfoDto> GetAllSample();
    }
}