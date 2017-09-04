using System.Collections.Generic;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Repositories.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        List<Movie> GetAllAndIncludePicturesAndSessions(params ISpecification<Movie>[] specifications);

        Movie GetByIdAndIncludeAllInfo(long movieId);

        List<Movie> GetAllAndIncludePictures(params ISpecification<Movie>[] specifications);
    }
}