using System;
using System.Linq.Expressions;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Concrete.Specifications.Generics
{
    public class CriteriaSpecification<TEntity> : IPredicateSpecification<TEntity> where TEntity : class 
    {
        public Expression<Func<TEntity, bool>> Predicate { get; set; }
    }
}