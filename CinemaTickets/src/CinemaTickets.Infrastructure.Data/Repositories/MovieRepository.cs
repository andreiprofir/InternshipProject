using System.Collections.Generic;
using System.Linq;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Interfaces;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaTickets.Infrastructure.Data.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(DbContext context, IQuerySpecificationBuilder<Movie> queryBuilder) : base(context, queryBuilder)
        {
        }


        public List<Movie> GetMoviesWithIncludePicturesAndSessions(params ISpecification<Movie>[] specifications)
        {
            IQueryable<Movie> queryWithSpecifications = CreateQuery(specifications);

            return queryWithSpecifications
                .Include(m => m.MovieSessions)
                .Include(m => m.Entity)
                    .ThenInclude(e => e.Pictures)
                .ToList();
        }
    }
}