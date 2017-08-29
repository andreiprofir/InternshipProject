using System;
using System.Linq;
using System.Linq.Expressions;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Domain.Interfaces.OrderSpecifications;
using CinemaTickets.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Remotion.Linq.Parsing.Structure;

namespace CinemaTickets.Infrastructure.Data.Concrete
{
    public class QuerySpecificationBuilder<TEntity> : IQuerySpecificationBuilder<TEntity> where TEntity : class
    {
        public IQueryable<TEntity> Build(IQueryable<TEntity> query, params ISpecification<TEntity>[] specifications)
        {
            return specifications.Aggregate(query, AddSpecification);
        }

        private static IQueryable<TEntity> AddSpecification(IQueryable<TEntity> query, ISpecification<TEntity> specification)
        {
            switch (specification)
            {
                case IOrderAscSpecification<TEntity> oa:
                    query = AddSpecification(query, oa);
                    break;

                case IOrderDescSpecification<TEntity> od:
                    query = AddSpecification(query, od);
                    break;

                case IPredicateSpecification<TEntity> p:
                    query = AddSpecification(query, p);
                    break;
            }

            return query;
        }

        private static IQueryable<TEntity> AddSpecification(IQueryable<TEntity> query, IOrderAscSpecification<TEntity> orderBy)
        {
            return orderBy?.KeySelector != null ? query.OrderBy(orderBy.KeySelector) : query;
        }

        private static IOrderedQueryable<TEntity> AddSpecification(IOrderedQueryable<TEntity> query, IOrderAscSpecification<TEntity> orderBy)
        {
            return orderBy?.KeySelector != null ? query.ThenBy(orderBy.KeySelector) : query;
        }

        private static IQueryable<TEntity> AddSpecification(IQueryable<TEntity> query, IOrderDescSpecification<TEntity> orderBy)
        {
            return orderBy?.KeySelector != null ? query.OrderByDescending(orderBy.KeySelector) : query;
        }

        private static IOrderedQueryable<TEntity> AddSpecification(IOrderedQueryable<TEntity> query, IOrderDescSpecification<TEntity> orderBy)
        {
            return orderBy?.KeySelector != null ? query.ThenByDescending(orderBy.KeySelector) : query;
        }

        private static IQueryable<TEntity> AddSpecification(IQueryable<TEntity> query,
            IPredicateSpecification<TEntity> criteria)
        {
            return criteria?.Predicate != null ? query.Where(criteria.Predicate) : query;
        }
    }
}