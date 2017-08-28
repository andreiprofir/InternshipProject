using System;
using System.Linq;
using System.Linq.Expressions;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Domain.Interfaces.OrderSpecification;
using CinemaTickets.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Parsing.Structure;

namespace CinemaTickets.Infrastructure.Data.Concrete
{
    public class QuerySpecificationBuilder<TEntity> : IQuerySpecificationBuilder<TEntity> where TEntity : class
    {
        public IQueryable<TEntity> Build(IQueryable<TEntity> query, params ISpecification<TEntity>[] specifications)
        {
            foreach (ISpecification<TEntity> specification in specifications)
            {
                query = AddSpecification(query, specification);
            }

            return query;
        }

        private IQueryable<TEntity> AddSpecification(IQueryable<TEntity> query, ISpecification<TEntity> specification)
        {
            return query;
        }

        private IQueryable<TEntity> AddSpecification(IQueryable<TEntity> query, IIncludeSpecification<TEntity> include)
        {
            return include?.Property != null ? query.Include(include.Property) : query;
        }

        private IQueryable<TEntity> AddSpecification(IQueryable<TEntity> query, IOrderAscSpecification<TEntity> orderBy)
        {
            return orderBy?.KeySelector != null ? query.OrderBy(orderBy.KeySelector) : query;
        }

        private IQueryable<TEntity> AddSpecification(IOrderedQueryable<TEntity> query, IOrderAscSpecification<TEntity> orderBy)
        {
            return orderBy?.KeySelector != null ? query.ThenBy(orderBy.KeySelector) : query;
        }

        private IQueryable<TEntity> AddSpecification(IQueryable<TEntity> query, IOrderDescSpecification<TEntity> orderBy)
        {
            return orderBy?.KeySelector != null ? query.OrderByDescending(orderBy.KeySelector) : query;
        }

        private IQueryable<TEntity> AddSpecification(IOrderedQueryable<TEntity> query, IOrderDescSpecification<TEntity> orderBy)
        {
            return orderBy?.KeySelector != null ? query.ThenByDescending(orderBy.KeySelector) : query;
        }

        private IQueryable<TEntity> AddSpecification(IQueryable<TEntity> query,
            IPredicateSpecification<TEntity> criteria)
        {
            return criteria?.Predicate != null ? query.Where(criteria.Predicate) : query;
        }
    }
}