using System.Collections.Generic;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Repositories.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        List<Movie> GetMoviesWithIncludePicturesAndSessions(params ISpecification<Movie>[] specifications);

        Movie GetMovieByIdAndIncludeAllInfo(long movieId);
    }
}