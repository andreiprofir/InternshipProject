using System.Collections.Generic;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Repositories.Interfaces
{
    public interface IGenreRepository : IRepository<Genre>
    {
        List<Genre> GetListOfGenresWithIncludePictures(params ISpecification<Genre>[] specifications);
    }
}