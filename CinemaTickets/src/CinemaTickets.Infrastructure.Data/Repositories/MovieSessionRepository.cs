using System.Collections.Generic;
using System.Linq;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Interfaces;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaTickets.Infrastructure.Data.Repositories
{
    public class MovieSessionRepository : Repository<MovieSession>, IMovieSessionRepository
    {
        public MovieSessionRepository(DbContext context, IQuerySpecificationBuilder<MovieSession> queryBuilder) : base(context, queryBuilder)
        {
        }


        public List<MovieSession> FindAllAndIncludeCinemaAndPrices(params ISpecification<MovieSession>[] specifications)
        {
            IQueryable<MovieSession> queryWithSpecifications = CreateQuery(specifications)
                .Include(ms => ms.SessionPrices)
                .Include(ms => ms.Hall)
                    .ThenInclude(h => h.Cinema);

            return queryWithSpecifications.ToList();
        }
    }
}