using System;
using System.Collections.Generic;
using System.Linq;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos.Genre;
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

        public List<Genre> GetListOfGenresWithIncludePictures()
        {
            IQueryable<Genre> queryWithSpecifications = CreateQuery();

            return queryWithSpecifications
                .Include(g => g.Entity)
                    .ThenInclude(e => e.Pictures)
                .OrderBy(e => e.Name)
                .ToList();
        }

        public Genre GetByIdWithIncludePicture(long genreId)
        {
            IQueryable<Genre> queryWithSpecifications = CreateQuery()
                .Where(g => g.Id == genreId);
                
            return queryWithSpecifications
                .Include(g => g.Entity)
                    .ThenInclude(e => e.Pictures)
                .FirstOrDefault();
        }
    }
}