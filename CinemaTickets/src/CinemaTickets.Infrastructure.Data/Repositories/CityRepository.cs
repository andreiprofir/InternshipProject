using System.Collections.Generic;
using System.Linq;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Interfaces;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaTickets.Infrastructure.Data.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(DbContext context, IQuerySpecificationBuilder<City> queryBuilder) : base(context, queryBuilder)
        {
        }

        public List<City> GetAllCitiesAndIncludeCinamas(params ISpecification<City>[] specifications)
        {
            IQueryable<City> queryWithSpecifications = CreateQuery(specifications)
                .Include(c => c.Cinemas);

            return queryWithSpecifications.ToList();
        }
    }
}