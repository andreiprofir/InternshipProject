using System;
using System.Linq.Expressions;

namespace CinemaTickets.Domain.Interfaces.OrderSpecification
{
    public interface IOrderSpecification<TEntity> : ISpecification<TEntity> where TEntity : class 
    {
        Expression<Func<TEntity, object>> KeySelector { get; set; }
    }
}