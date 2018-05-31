using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CinemaTickets.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : class
    {
        List<TEntity> GetAll();

        TEntity Get(long id);

        List<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        List<TEntity> Find(params ISpecification<TEntity>[] specifications);

        TEntity Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Delete(long id);

        int SaveChanges();
    }
}