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

        Task<List<TEntity>> GetAllAsync();

        TEntity Get(long id);

        Task<TEntity> GetAsync(long id);

        List<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        List<TEntity> Find(params ISpecification<TEntity>[] specifications);

        Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

        Task<List<TEntity>> FindAsync(params ISpecification<TEntity>[] specifications);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Delete(long id);

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}