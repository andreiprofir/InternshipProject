using System.Linq;
using CinemaTickets.Domain.Interfaces;

namespace CinemaTickets.Infrastructure.Data.Interfaces
{
    public interface IQuerySpecificationBuilder<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Build(IQueryable<TEntity> query, params ISpecification<TEntity>[] specifications);
    }
}