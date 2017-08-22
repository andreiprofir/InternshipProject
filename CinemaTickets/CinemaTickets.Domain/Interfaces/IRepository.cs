using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CinemaTickets.Domain.Core.Models;

namespace CinemaTickets.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(long id);

        Task<TEntity> GetAsync(long id);

        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Delete(long id);

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}