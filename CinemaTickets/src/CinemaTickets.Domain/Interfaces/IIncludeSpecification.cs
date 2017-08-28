using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CinemaTickets.Domain.Interfaces
{
    public interface IIncludeSpecification<TEntity> : ISpecification<TEntity> where TEntity : class
    {
        Expression<Func<TEntity, object>> Property { get; set; }
    }
}