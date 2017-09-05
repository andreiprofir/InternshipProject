using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Interfaces;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CinemaTickets.Infrastructure.Data.Repositories
{
    public class CinemaRepository : Repository<Cinema>, ICinemaRepository
    {
        public CinemaRepository(DbContext context, IQuerySpecificationBuilder<Cinema> queryBuilder) : base(context, queryBuilder)
        {
        }

        public List<Cinema> GetAllIncludeCityAndHallsAndPictures(params ISpecification<Cinema>[] specifications)
        {
            IQueryable<Cinema> queryWithSpecifications = CreateQuery(specifications)
                .Include(c => c.Entity)
                    .ThenInclude(e => e.Pictures)
                .Include(c => c.City)
                .Include(c => c.Halls);

            return queryWithSpecifications.ToList();
        }
    }
}