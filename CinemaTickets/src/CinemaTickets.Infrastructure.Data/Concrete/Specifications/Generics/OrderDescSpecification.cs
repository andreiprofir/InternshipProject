using System;
using System.Linq.Expressions;
using CinemaTickets.Domain.Interfaces.OrderSpecifications;

namespace CinemaTickets.Infrastructure.Data.Concrete.Specifications.Generics
{
    public class OrderDescSpecification<TEntity> : IOrderDescSpecification<TEntity> where TEntity : class 
    {
        public Expression<Func<TEntity, object>> KeySelector { get; set; }
    }
}