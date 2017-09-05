using System.Collections.Generic;
using CinemaTickets.Domain.Dtos.Genre;

namespace CinemaTickets.Services.Interfaces
{
    public interface IGenreService
    {
        List<GenreBaseInfoDto> GetAllNames();

        GenreSampleInfoDto GetById(long genreId);
    }
}