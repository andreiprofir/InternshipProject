using System.Collections.Generic;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Genre;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Repositories.Interfaces
{
    public interface IGenreRepository : IRepository<Genre>
    {
        List<Genre> GetListOfGenresWithIncludePictures();

        Genre GetByIdWithIncludePicture(long genreId);
    }
}