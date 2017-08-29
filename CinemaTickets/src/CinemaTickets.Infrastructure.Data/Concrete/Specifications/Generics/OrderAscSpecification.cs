using System;
using System.Linq.Expressions;
using CinemaTickets.Domain.Interfaces.OrderSpecifications;

namespace CinemaTickets.Infrastructure.Data.Concrete.Specifications.Generics
{
    public class OrderAscSpecification<TEntity> : IOrderAscSpecification<TEntity> where TEntity : class
    {
        public Expression<Func<TEntity, object>> KeySelector { get; set; }
    }
}