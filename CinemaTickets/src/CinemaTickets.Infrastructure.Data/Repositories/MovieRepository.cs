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


        public List<Movie> GetAllAndIncludePicturesAndSessions(params ISpecification<Movie>[] specifications)
        {
            IQueryable<Movie> queryWithSpecifications = CreateQuery(specifications);

            return queryWithSpecifications
                .Include(m => m.MovieSessions)
                .Include(m => m.Entity)
                    .ThenInclude(e => e.Pictures)
                .ToList();
        }

        public Movie GetByIdAndIncludeAllInfo(long movieId)
        {
            IQueryable<Movie> query = CreateQuery()
                .Include(m => m.Entity)
                    .ThenInclude(e => e.Pictures)
                .Include(m => m.MovieActors)
                    .ThenInclude(ma => ma.Actor)
                .Include(m => m.MovieCountries)
                    .ThenInclude(mc => mc.Country)
                .Include(m => m.MovieDirectors)
                    .ThenInclude(md => md.Director)
                .Include(m => m.MovieLanguages)
                    .ThenInclude(ml => ml.Language)
                .Include(m => m.MovieWriters)
                    .ThenInclude(mw => mw.Writer)
                .Include(m => m.MovieGenres)
                    .ThenInclude(mg => mg.Genre)
                .Include(m => m.Entity)
                    .ThenInclude(e => e.Comments)
                .Include(m => m.MovieSessions)
                    .ThenInclude(ms => ms.Hall)
                        .ThenInclude(h => h.Cinema)
                .Include(m => m.MovieSessions)
                    .ThenInclude(ms => ms.SessionPrices);

            return query.FirstOrDefault(m => m.Id == movieId);
        }

        public List<Movie> GetAllAndIncludePictures(params ISpecification<Movie>[] specifications)
        {
            IQueryable<Movie> queryWithSpecifications = CreateQuery(specifications)
                .Include(m => m.Entity)
                    .ThenInclude(e => e.Pictures)
                .Include(m => m.MovieSessions)
                    .ThenInclude(ms => ms.SessionPrices)
                .Include(m => m.MovieSessions)
                    .ThenInclude(ms => ms.Hall)
                        .ThenInclude(h => h.Cinema);

            return queryWithSpecifications.ToList();
        }
    }
}