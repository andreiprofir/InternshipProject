using System.Collections.Generic;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Repositories.Interfaces
{
    public interface IMovieSessionRepository : IRepository<MovieSession>
    {
        List<MovieSession> FindAllAndIncludeCinemaAndPrices(params ISpecification<MovieSession>[] specifications);
    }
}