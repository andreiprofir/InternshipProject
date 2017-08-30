using System;
using System.Collections.Generic;
using System.Linq;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Interfaces;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaTickets.Infrastructure.Data.Repositories
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(DbContext context, IQuerySpecificationBuilder<Genre> queryBuilder) 
            : base(context, queryBuilder)
        {
        }

        public List<Genre> GetListOfGenresWithIncludePictures(params ISpecification<Genre>[] specifications)
        {
            IQueryable<Genre> queryWithSpecifications = CreateQuery(specifications);

            return queryWithSpecifications
                .Include(g => g.Entity)
                    .ThenInclude(e => e.Pictures)
                .ToList();
        }
    }
}