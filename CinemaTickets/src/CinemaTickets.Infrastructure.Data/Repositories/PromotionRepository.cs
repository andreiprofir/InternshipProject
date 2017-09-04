using System.Collections.Generic;
using System.Linq;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Interfaces;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaTickets.Infrastructure.Data.Repositories
{
    public class PromotionRepository : Repository<Promotion>, IPromotionRepository
    {
        public PromotionRepository(DbContext context, IQuerySpecificationBuilder<Promotion> queryBuilder) : base(context, queryBuilder)
        {
        }

        public Promotion GetByIdWithIncludes(long promotionId)
        {
            IQueryable<Promotion> query = CreateQuery()
                .Include(p => p.Entity)
                    .ThenInclude(e => e.Pictures)
                .Include(p => p.MoviePromotions)
                    .ThenInclude(mp => mp.Movie)
                        .ThenInclude(m => m.Entity)
                            .ThenInclude(e => e.Pictures)
                .Include(p => p.CinemaPromotions)
                    .ThenInclude(cp => cp.Cinema)
                        .ThenInclude(c => c.City);

            return query.FirstOrDefault(p => p.Id == promotionId);
        }

        public List<Promotion> GetAllWithIncludePicturesAndCinemas(params ISpecification<Promotion>[] specifications)
        {
            IQueryable<Promotion> queryWithSpecifications = CreateQuery(specifications)
                .Include(p => p.Entity)
                    .ThenInclude(e => e.Pictures)
                .Include(p => p.CinemaPromotions)
                    .ThenInclude(mp => mp.Cinema);

            return queryWithSpecifications.ToList();
        }
    }
}