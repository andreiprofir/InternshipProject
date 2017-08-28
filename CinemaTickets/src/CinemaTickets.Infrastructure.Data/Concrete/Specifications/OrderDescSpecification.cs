using System;
using System.Linq.Expressions;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Domain.Interfaces.OrderSpecification;

namespace CinemaTickets.Infrastructure.Data.Concrete.Specifications
{
    public class OrderDescSpecification<TEntity> : IOrderDescSpecification<TEntity> where TEntity : class 
    {
        public Expression<Func<TEntity, object>> KeySelector { get; set; }
    }
}