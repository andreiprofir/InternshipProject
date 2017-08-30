using System;
using System.Linq.Expressions;
using CinemaTickets.Infrastructure.Data.Concrete.Specifications.Generics;

namespace CinemaTickets.Infrastructure.Data.Concrete.Specifications
{
    public class Specification
    {
        public static CriteriaSpecification<TEntity> Where<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            return new CriteriaSpecification<TEntity> { Predicate = predicate };
        }

        public static OrderAscSpecification<TEntity> OrderBy<TEntity>(Expression<Func<TEntity, object>> predicate) where TEntity : class
        {
            return new OrderAscSpecification<TEntity> { KeySelector = predicate };
        }

        public static OrderDescSpecification<TEntity> OrderByDescending<TEntity>(Expression<Func<TEntity, object>> predicate) where TEntity : class
        {
            return new OrderDescSpecification<TEntity> { KeySelector = predicate };
        }
    }
}