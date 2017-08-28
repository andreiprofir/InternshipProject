using System;
using System.Linq.Expressions;

namespace CinemaTickets.Domain.Interfaces
{
    public interface IPredicateSpecification<TEntity> : ISpecification<TEntity> where TEntity : class
    {
        Expression<Func<TEntity, bool>> Predicate { get; set; }
    }
}