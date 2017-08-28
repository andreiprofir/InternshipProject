using System;
using System.Linq.Expressions;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Concrete.Specifications
{
    public class IncludeSpecification<TEntity> : IIncludeSpecification<TEntity> where TEntity : class 
    {
        public Expression<Func<TEntity, object>> Property { get; set; }
    }
}